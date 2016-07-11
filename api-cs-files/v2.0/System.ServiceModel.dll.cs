namespace Mono.CodeGeneration {
  public partial class CodeAdd : Mono.CodeGeneration.CodeArithmeticOperation {
    public CodeAdd(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
  }
  public partial class CodeAddOne : Mono.CodeGeneration.CodeExpression {
    public CodeAddOne(Mono.CodeGeneration.CodeValueReference exp) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeAnd : Mono.CodeGeneration.CodeConditionExpression {
    public CodeAnd(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool branchCase) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeArgument : Mono.CodeGeneration.CodeExpression {
    public CodeArgument(int arg, System.Type type) { }
    public int Argument { get { return default(int); } }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeArgumentReference : Mono.CodeGeneration.CodeValueReference {
    public CodeArgumentReference(System.Type type, int argNum, string name) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateSet(System.Reflection.Emit.ILGenerator gen, Mono.CodeGeneration.CodeExpression value) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public abstract partial class CodeArithmeticOperation : Mono.CodeGeneration.CodeExpression {
    protected Mono.CodeGeneration.CodeExpression exp1;
    protected Mono.CodeGeneration.CodeExpression exp2;
    protected string symbol;
    protected System.Type t1;
    protected System.Type t2;
    protected CodeArithmeticOperation() { }
    public CodeArithmeticOperation(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2, string symbol) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeArrayItem : Mono.CodeGeneration.CodeValueReference {
    public CodeArrayItem(Mono.CodeGeneration.CodeExpression array, Mono.CodeGeneration.CodeExpression index) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateSet(System.Reflection.Emit.ILGenerator gen, Mono.CodeGeneration.CodeExpression value) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeArrayLength : Mono.CodeGeneration.CodeExpression {
    public CodeArrayLength(Mono.CodeGeneration.CodeExpression array) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeAssignment : Mono.CodeGeneration.CodeExpression {
    public CodeAssignment(Mono.CodeGeneration.CodeValueReference var, Mono.CodeGeneration.CodeExpression exp) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateAsStatement(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public abstract partial class CodeBinaryComparison : Mono.CodeGeneration.CodeConditionExpression {
    protected Mono.CodeGeneration.CodeExpression exp1;
    protected Mono.CodeGeneration.CodeExpression exp2;
    protected System.Type t1;
    protected System.Type t2;
    public CodeBinaryComparison(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2, string symbol) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public abstract partial class CodeBinaryOperation : Mono.CodeGeneration.CodeConditionExpression {
    protected Mono.CodeGeneration.CodeExpression exp1;
    protected Mono.CodeGeneration.CodeExpression exp2;
    protected System.Type t1;
    protected System.Type t2;
    public CodeBinaryOperation(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2, string symbol) { }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeBlock : Mono.CodeGeneration.CodeItem {
    public CodeBlock() { }
    public bool IsEmpty { get { return default(bool); } }
    public void Add(Mono.CodeGeneration.CodeItem code) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public Mono.CodeGeneration.CodeItem GetLastItem() { return default(Mono.CodeGeneration.CodeItem); }
    public static Mono.CodeGeneration.CodeBlock operator +(Mono.CodeGeneration.CodeBlock cb, Mono.CodeGeneration.CodeExpression e) { return default(Mono.CodeGeneration.CodeBlock); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeBuilder {
    public CodeBuilder(Mono.CodeGeneration.CodeClass codeClass) { }
    public Mono.CodeGeneration.CodeBlock CurrentBlock { get { return default(Mono.CodeGeneration.CodeBlock); } }
    public Mono.CodeGeneration.CodeClass OwnerClass { get { return default(Mono.CodeGeneration.CodeClass); } }
    public void Assign(Mono.CodeGeneration.CodeValueReference var, Mono.CodeGeneration.CodeExpression val) { }
    public void Call(Mono.CodeGeneration.CodeExpression target, Mono.CodeGeneration.CodeMethod method, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public void Call(Mono.CodeGeneration.CodeExpression target, System.Reflection.MethodBase method, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public void Call(Mono.CodeGeneration.CodeExpression target, string name, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public void Call(Mono.CodeGeneration.CodeMethod method, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public void Call(System.Reflection.MethodInfo method, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public void Call(System.Type type, string name, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public Mono.CodeGeneration.CodeExpression CallFunc(Mono.CodeGeneration.CodeExpression target, Mono.CodeGeneration.CodeMethod method, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeExpression CallFunc(Mono.CodeGeneration.CodeExpression target, System.Reflection.MethodInfo method, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeExpression CallFunc(Mono.CodeGeneration.CodeExpression target, string name, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeExpression CallFunc(Mono.CodeGeneration.CodeMethod method, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeExpression CallFunc(System.Reflection.MethodInfo method, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeExpression CallFunc(System.Type type, string name, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public void Case(Mono.CodeGeneration.CodeExpression condition) { }
    public void ConsoleWriteLine(params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public void ConsoleWriteLine(params System.Object[] parameters) { }
    public void Dec(Mono.CodeGeneration.CodeValueReference val) { }
    public Mono.CodeGeneration.CodeVariableReference DeclareVariable(Mono.CodeGeneration.CodeExpression initValue) { return default(Mono.CodeGeneration.CodeVariableReference); }
    public Mono.CodeGeneration.CodeVariableReference DeclareVariable(System.Type type) { return default(Mono.CodeGeneration.CodeVariableReference); }
    public Mono.CodeGeneration.CodeVariableReference DeclareVariable(System.Type type, Mono.CodeGeneration.CodeExpression initValue) { return default(Mono.CodeGeneration.CodeVariableReference); }
    public Mono.CodeGeneration.CodeVariableReference DeclareVariable(System.Type type, object ob) { return default(Mono.CodeGeneration.CodeVariableReference); }
    public void Else() { }
    public void ElseIf(Mono.CodeGeneration.CodeExpression condition) { }
    public void EndFor() { }
    public void EndForeach() { }
    public void EndIf() { }
    public void EndSelect() { }
    public void EndWhile() { }
    public void For(Mono.CodeGeneration.CodeExpression initExp, Mono.CodeGeneration.CodeExpression conditionExp, Mono.CodeGeneration.CodeExpression nextExp) { }
    public void Foreach(System.Type type, out Mono.CodeGeneration.CodeExpression item, Mono.CodeGeneration.CodeExpression array) { item = default(Mono.CodeGeneration.CodeExpression); }
    public void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public void If(Mono.CodeGeneration.CodeExpression condition) { }
    public void Inc(Mono.CodeGeneration.CodeValueReference val) { }
    public static Mono.CodeGeneration.CodeBuilder operator +(Mono.CodeGeneration.CodeBuilder cb, Mono.CodeGeneration.CodeItem e) { return default(Mono.CodeGeneration.CodeBuilder); }
    public string PrintCode() { return default(string); }
    public void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
    public void Return() { }
    public void Return(Mono.CodeGeneration.CodeExpression exp) { }
    public void Select() { }
    public Mono.CodeGeneration.CodeExpression When(Mono.CodeGeneration.CodeExpression condition, Mono.CodeGeneration.CodeExpression trueResult, Mono.CodeGeneration.CodeExpression falseResult) { return default(Mono.CodeGeneration.CodeExpression); }
    public void While(Mono.CodeGeneration.CodeExpression condition) { }
  }
  public partial class CodeCast : Mono.CodeGeneration.CodeExpression {
    public CodeCast(System.Type type, Mono.CodeGeneration.CodeExpression exp) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeClass {
    public CodeClass(System.Reflection.Emit.ModuleBuilder mb, string name) { }
    public CodeClass(System.Reflection.Emit.ModuleBuilder mb, string name, System.Reflection.TypeAttributes attr, System.Type baseType, params System.Type[] interfaces) { }
    public CodeClass(System.Reflection.Emit.ModuleBuilder mb, string name, System.Type baseType, params System.Type[] interfaces) { }
    public System.Reflection.Emit.TypeBuilder TypeBuilder { get { return default(System.Reflection.Emit.TypeBuilder); } }
    public Mono.CodeGeneration.CodeMethod CreateConstructor(System.Reflection.MethodAttributes attributes, params System.Type[] parameters) { return default(Mono.CodeGeneration.CodeMethod); }
    public Mono.CodeGeneration.CodeMethod CreateConstructor(params System.Type[] parameters) { return default(Mono.CodeGeneration.CodeMethod); }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType, System.Type[] ctorArgTypes, Mono.CodeGeneration.CodeLiteral[] ctorArgs, System.Reflection.FieldInfo[] fields, Mono.CodeGeneration.CodeLiteral[] fieldValues) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType, System.Type[] ctorArgTypes, System.Object[] ctorArgs, System.String[] namedArgFieldNames, System.Object[] namedArgValues) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public Mono.CodeGeneration.CodeMethod CreateMethod(string name, System.Reflection.MethodAttributes attributes, System.Type returnType, params System.Type[] parameterTypes) { return default(Mono.CodeGeneration.CodeMethod); }
    public Mono.CodeGeneration.CodeMethod CreateMethod(string name, System.Type returnType, params System.Type[] parameterTypes) { return default(Mono.CodeGeneration.CodeMethod); }
    public Mono.CodeGeneration.CodeProperty CreateProperty(string name, System.Type returnType, System.Reflection.MethodAttributes methodAttributes, params System.Type[] parameterTypes) { return default(Mono.CodeGeneration.CodeProperty); }
    public Mono.CodeGeneration.CodeProperty CreateProperty(string name, System.Type returnType, params System.Type[] parameterTypes) { return default(Mono.CodeGeneration.CodeProperty); }
    public Mono.CodeGeneration.CodeMethod CreateStaticMethod(string name, System.Type returnType, params System.Type[] parameterTypes) { return default(Mono.CodeGeneration.CodeMethod); }
    public System.Type CreateType() { return default(System.Type); }
    public Mono.CodeGeneration.CodeMethod CreateVirtualMethod(string name, System.Type returnType, params System.Type[] parameterTypes) { return default(Mono.CodeGeneration.CodeMethod); }
    public Mono.CodeGeneration.CodeFieldReference DefineField(string name, System.Type type, params Mono.CodeGeneration.CodeCustomAttribute[] customAttributes) { return default(Mono.CodeGeneration.CodeFieldReference); }
    public Mono.CodeGeneration.CodeFieldReference DefineField(string name, System.Type type, System.Reflection.FieldAttributes attrs, Mono.CodeGeneration.CodeExpression initialValue, params Mono.CodeGeneration.CodeCustomAttribute[] customAttributes) { return default(Mono.CodeGeneration.CodeFieldReference); }
    public Mono.CodeGeneration.CodeFieldReference DefineStaticField(Mono.CodeGeneration.CodeExpression initialValue, params Mono.CodeGeneration.CodeCustomAttribute[] customAttributes) { return default(Mono.CodeGeneration.CodeFieldReference); }
    public Mono.CodeGeneration.CodeFieldReference DefineStaticField(string name, System.Type type, Mono.CodeGeneration.CodeExpression initialValue, params Mono.CodeGeneration.CodeCustomAttribute[] customAttributes) { return default(Mono.CodeGeneration.CodeFieldReference); }
    public Mono.CodeGeneration.CodeMethod GetDefaultConstructor() { return default(Mono.CodeGeneration.CodeMethod); }
    public Mono.CodeGeneration.CodeMethod GetStaticConstructor() { return default(Mono.CodeGeneration.CodeMethod); }
    public Mono.CodeGeneration.CodeMethod ImplementMethod(System.Reflection.MethodInfo basem) { return default(Mono.CodeGeneration.CodeMethod); }
    public Mono.CodeGeneration.CodeMethod ImplementMethod(System.Type baseType, System.Reflection.MethodInfo basem) { return default(Mono.CodeGeneration.CodeMethod); }
    public Mono.CodeGeneration.CodeMethod ImplementMethod(System.Type baseType, string methodName) { return default(Mono.CodeGeneration.CodeMethod); }
    public string PrintCode() { return default(string); }
    public void PrintCode(Mono.CodeGeneration.CodeWriter cw) { }
  }
  public abstract partial class CodeConditionExpression : Mono.CodeGeneration.CodeExpression {
    protected CodeConditionExpression() { }
    public virtual void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool jumpCase) { }
  }
  public partial class CodeCustomAttribute {
    public CodeCustomAttribute(System.Reflection.Emit.CustomAttributeBuilder attributeBuilder, System.Type type, System.Reflection.ConstructorInfo constructor, Mono.CodeGeneration.CodeLiteral[] ctorArgs, System.Reflection.MemberInfo[] namedArgMembers, Mono.CodeGeneration.CodeLiteral[] namedArgValues) { }
    public System.Reflection.Emit.CustomAttributeBuilder Builder { get { return default(System.Reflection.Emit.CustomAttributeBuilder); } }
    public static Mono.CodeGeneration.CodeCustomAttribute Create(System.Type attributeType) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public static Mono.CodeGeneration.CodeCustomAttribute Create(System.Type attributeType, System.Type[] ctorArgTypes, Mono.CodeGeneration.CodeLiteral[] ctorArgs, System.Reflection.MemberInfo[] members, Mono.CodeGeneration.CodeLiteral[] values) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public static Mono.CodeGeneration.CodeCustomAttribute Create(System.Type attributeType, System.Type[] ctorArgTypes, System.Object[] ctorArgs, System.String[] namedArgNames, System.Object[] namedArgValues) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public string PrintCode() { return default(string); }
    public void PrintCode(Mono.CodeGeneration.CodeWriter cw) { }
  }
  public partial class CodeDecrement : Mono.CodeGeneration.CodeValueReference {
    public CodeDecrement(Mono.CodeGeneration.CodeValueReference exp) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateSet(System.Reflection.Emit.ILGenerator gen, Mono.CodeGeneration.CodeExpression value) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeDiv : Mono.CodeGeneration.CodeArithmeticOperation {
    public CodeDiv(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
  }
  public partial class CodeEquals : Mono.CodeGeneration.CodeConditionExpression {
    public CodeEquals(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool branchCase) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public abstract partial class CodeExpression : Mono.CodeGeneration.CodeItem {
    protected CodeExpression() { }
    public Mono.CodeGeneration.CodeExpression ArrayLength { get { return default(Mono.CodeGeneration.CodeExpression); } }
    public Mono.CodeGeneration.CodeExpression IsNull { get { return default(Mono.CodeGeneration.CodeExpression); } }
    public bool IsNumber { get { return default(bool); } }
    public Mono.CodeGeneration.CodeValueReference this[Mono.CodeGeneration.CodeExpression index] { get { return default(Mono.CodeGeneration.CodeValueReference); } }
    public Mono.CodeGeneration.CodeValueReference this[System.Reflection.FieldInfo field] { get { return default(Mono.CodeGeneration.CodeValueReference); } }
    public Mono.CodeGeneration.CodeValueReference this[System.Reflection.PropertyInfo prop] { get { return default(Mono.CodeGeneration.CodeValueReference); } }
    public Mono.CodeGeneration.CodeValueReference this[string name] { get { return default(Mono.CodeGeneration.CodeValueReference); } }
    public static Mono.CodeGeneration.CodeExpression Add(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeExpression And(Mono.CodeGeneration.CodeExpression other) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression AreEqual(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression AreNotEqual(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeExpression Call(System.Reflection.MethodInfo method, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeExpression Call(string name, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeExpression CallToString() { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeExpression CastTo(System.Type type) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Divide(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
    public virtual void GenerateAsStatement(System.Reflection.Emit.ILGenerator gen) { }
    public abstract System.Type GetResultType();
    public Mono.CodeGeneration.CodeExpression Is(System.Type type) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression IsGreaterEqualThan(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression IsGreaterThan(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression IsSmallerEqualThan(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression IsSmallerThan(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
    public Mono.CodeGeneration.CodeValueReference MemGet(System.Reflection.MemberInfo member) { return default(Mono.CodeGeneration.CodeValueReference); }
    public Mono.CodeGeneration.CodeValueReference MemGet(string name) { return default(Mono.CodeGeneration.CodeValueReference); }
    public static Mono.CodeGeneration.CodeExpression Multiply(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Not(Mono.CodeGeneration.CodeExpression e) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression NullValue(System.Type type) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Subtract(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
  }
  public partial class CodeFieldReference : Mono.CodeGeneration.CodeValueReference {
    public CodeFieldReference(Mono.CodeGeneration.CodeExpression target, System.Reflection.FieldInfo field) { }
    public CodeFieldReference(System.Reflection.FieldInfo field) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateSet(System.Reflection.Emit.ILGenerator gen, Mono.CodeGeneration.CodeExpression value) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeFor : Mono.CodeGeneration.CodeStatement {
    public CodeFor(Mono.CodeGeneration.CodeExpression initExp, Mono.CodeGeneration.CodeExpression conditionExp, Mono.CodeGeneration.CodeExpression nextExp) { }
    public Mono.CodeGeneration.CodeBlock ForBlock { get { return default(Mono.CodeGeneration.CodeBlock); } set { } }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeForeach : Mono.CodeGeneration.CodeStatement {
    public CodeForeach(Mono.CodeGeneration.CodeExpression array, System.Type itemType) { }
    public Mono.CodeGeneration.CodeBlock ForBlock { get { return default(Mono.CodeGeneration.CodeBlock); } set { } }
    public Mono.CodeGeneration.CodeValueReference ItemExpression { get { return default(Mono.CodeGeneration.CodeValueReference); } }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeGenerationHelper {
    public CodeGenerationHelper() { }
    public static void GenerateMethodCall(System.Reflection.Emit.ILGenerator gen, Mono.CodeGeneration.CodeExpression target, Mono.CodeGeneration.CodeMethod method, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public static void GenerateMethodCall(System.Reflection.Emit.ILGenerator gen, Mono.CodeGeneration.CodeExpression target, System.Reflection.MethodBase method, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public static void GeneratePrimitiveValue() { }
    public static void GenerateSafeConversion(System.Reflection.Emit.ILGenerator gen, System.Type targetType, System.Type sourceType) { }
    public static System.Exception GetMethodException(System.Reflection.MethodBase method, string msg) { return default(System.Exception); }
    public static bool IsNumber(System.Type t) { return default(bool); }
    public static void LoadFromPtr(System.Reflection.Emit.ILGenerator ig, System.Type t) { }
    public static void SaveToPtr(System.Reflection.Emit.ILGenerator ig, System.Type t) { }
  }
  public partial class CodeGreaterEqualThan : Mono.CodeGeneration.CodeBinaryComparison {
    public CodeGreaterEqualThan(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) : base (default(Mono.CodeGeneration.CodeExpression), default(Mono.CodeGeneration.CodeExpression), default(string)) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool branchCase) { }
  }
  public partial class CodeGreaterThan : Mono.CodeGeneration.CodeBinaryComparison {
    public CodeGreaterThan(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) : base (default(Mono.CodeGeneration.CodeExpression), default(Mono.CodeGeneration.CodeExpression), default(string)) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool branchCase) { }
  }
  public partial class CodeIf : Mono.CodeGeneration.CodeStatement {
    public CodeIf(Mono.CodeGeneration.CodeExpression condition) { }
    public Mono.CodeGeneration.CodeBlock FalseBlock { get { return default(Mono.CodeGeneration.CodeBlock); } set { } }
    public Mono.CodeGeneration.CodeBlock TrueBlock { get { return default(Mono.CodeGeneration.CodeBlock); } set { } }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeIncrement : Mono.CodeGeneration.CodeValueReference {
    public CodeIncrement(Mono.CodeGeneration.CodeValueReference exp) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateAsStatement(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateSet(System.Reflection.Emit.ILGenerator gen, Mono.CodeGeneration.CodeExpression value) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeIs : Mono.CodeGeneration.CodeConditionExpression {
    public CodeIs(System.Type type, Mono.CodeGeneration.CodeExpression exp) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool branchCase) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public abstract partial class CodeItem {
    protected CodeItem() { }
    public abstract void Generate(System.Reflection.Emit.ILGenerator gen);
    public abstract void PrintCode(Mono.CodeGeneration.CodeWriter cp);
  }
  public partial class CodeLessEqualThan : Mono.CodeGeneration.CodeBinaryComparison {
    public CodeLessEqualThan(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) : base (default(Mono.CodeGeneration.CodeExpression), default(Mono.CodeGeneration.CodeExpression), default(string)) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool branchCase) { }
  }
  public partial class CodeLessThan : Mono.CodeGeneration.CodeBinaryComparison {
    public CodeLessThan(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) : base (default(Mono.CodeGeneration.CodeExpression), default(Mono.CodeGeneration.CodeExpression), default(string)) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool branchCase) { }
  }
  public partial class CodeLiteral : Mono.CodeGeneration.CodeExpression {
    public CodeLiteral(object value) { }
    public CodeLiteral(object value, System.Type type) { }
    public object Value { get { return default(object); } }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeMethod {
    internal CodeMethod() { }
    public System.Reflection.MethodAttributes Attributes { get { return default(System.Reflection.MethodAttributes); } }
    public Mono.CodeGeneration.CodeBuilder CodeBuilder { get { return default(Mono.CodeGeneration.CodeBuilder); } }
    public System.Reflection.Emit.TypeBuilder DeclaringType { get { return default(System.Reflection.Emit.TypeBuilder); } }
    public bool IsStatic { get { return default(bool); } }
    public System.Reflection.MethodBase MethodBase { get { return default(System.Reflection.MethodBase); } }
    public System.Reflection.MethodInfo MethodInfo { get { return default(System.Reflection.MethodInfo); } }
    public string Name { get { return default(string); } }
    public System.Type[] ParameterTypes { get { return default(System.Type[]); } }
    public System.Type ReturnType { get { return default(System.Type); } }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType, System.Type[] ctorArgTypes, Mono.CodeGeneration.CodeLiteral[] ctorArgs, System.Reflection.FieldInfo[] fields, Mono.CodeGeneration.CodeLiteral[] fieldValues) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType, System.Type[] ctorArgTypes, System.Object[] ctorArgs) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType, System.Type[] ctorArgTypes, System.Object[] ctorArgs, System.String[] namedArgFieldNames, System.Object[] namedArgValues) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public static Mono.CodeGeneration.CodeMethod DefineConstructor(Mono.CodeGeneration.CodeClass cls, System.Reflection.MethodAttributes attributes, System.Type[] parameterTypes) { return default(Mono.CodeGeneration.CodeMethod); }
    public void Generate() { }
    public Mono.CodeGeneration.CodeArgumentReference GetArg(int n) { return default(Mono.CodeGeneration.CodeArgumentReference); }
    public Mono.CodeGeneration.CodeArgumentReference GetThis() { return default(Mono.CodeGeneration.CodeArgumentReference); }
    public string PrintCode() { return default(string); }
    public virtual void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
    public void UpdateMethodBase(System.Type type) { }
  }
  public partial class CodeMethodCall : Mono.CodeGeneration.CodeExpression {
    public CodeMethodCall(Mono.CodeGeneration.CodeExpression target, Mono.CodeGeneration.CodeMethod method, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public CodeMethodCall(Mono.CodeGeneration.CodeExpression target, System.Reflection.MethodBase method, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public CodeMethodCall(Mono.CodeGeneration.CodeExpression target, string name, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public CodeMethodCall(Mono.CodeGeneration.CodeMethod method, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public CodeMethodCall(System.Reflection.MethodInfo method, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public CodeMethodCall(System.Type type, string name, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateAsStatement(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeModule {
    public CodeModule(string name) { }
    public System.Reflection.Emit.ModuleBuilder ModuleBuilder { get { return default(System.Reflection.Emit.ModuleBuilder); } }
    public static Mono.CodeGeneration.CodeModule Shared { get { return default(Mono.CodeGeneration.CodeModule); } }
    public Mono.CodeGeneration.CodeClass CreateClass(string name) { return default(Mono.CodeGeneration.CodeClass); }
    public Mono.CodeGeneration.CodeClass CreateClass(string name, System.Reflection.TypeAttributes attr, System.Type baseType, params System.Type[] interfaces) { return default(Mono.CodeGeneration.CodeClass); }
    public Mono.CodeGeneration.CodeClass CreateClass(string name, System.Type baseType, params System.Type[] interfaces) { return default(Mono.CodeGeneration.CodeClass); }
  }
  public partial class CodeMul : Mono.CodeGeneration.CodeArithmeticOperation {
    public CodeMul(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
  }
  public partial class CodeNeg : Mono.CodeGeneration.CodeExpression {
    public CodeNeg(Mono.CodeGeneration.CodeExpression exp) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeNew : Mono.CodeGeneration.CodeExpression {
    public CodeNew(System.Type type, params Mono.CodeGeneration.CodeExpression[] parameters) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeNewArray : Mono.CodeGeneration.CodeExpression {
    public CodeNewArray(System.Type type, Mono.CodeGeneration.CodeExpression size) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeNot : Mono.CodeGeneration.CodeConditionExpression {
    public CodeNot(Mono.CodeGeneration.CodeExpression exp) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool branchCase) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeNotEquals : Mono.CodeGeneration.CodeConditionExpression {
    public CodeNotEquals(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool branchCase) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeOr : Mono.CodeGeneration.CodeConditionExpression {
    public CodeOr(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateForBranch(System.Reflection.Emit.ILGenerator gen, System.Reflection.Emit.Label label, bool branchCase) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeProperty {
    internal CodeProperty() { }
    public System.Reflection.PropertyAttributes Attributes { get { return default(System.Reflection.PropertyAttributes); } }
    public Mono.CodeGeneration.CodeBuilder CodeBuilderGet { get { return default(Mono.CodeGeneration.CodeBuilder); } }
    public Mono.CodeGeneration.CodeBuilder CodeBuilderSet { get { return default(Mono.CodeGeneration.CodeBuilder); } }
    public System.Reflection.Emit.TypeBuilder DeclaringType { get { return default(System.Reflection.Emit.TypeBuilder); } }
    public bool IsPublic { get { return default(bool); } }
    public bool IsStatic { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public System.Type[] ParameterTypes { get { return default(System.Type[]); } }
    public System.Reflection.Emit.PropertyBuilder PropertyBuilder { get { return default(System.Reflection.Emit.PropertyBuilder); } }
    public System.Type ReturnType { get { return default(System.Type); } }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType, System.Type[] ctorArgTypes, Mono.CodeGeneration.CodeLiteral[] ctorArgs, System.Reflection.FieldInfo[] fields, Mono.CodeGeneration.CodeLiteral[] fieldValues) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType, System.Type[] ctorArgTypes, System.Object[] ctorArgs) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public Mono.CodeGeneration.CodeCustomAttribute CreateCustomAttribute(System.Type attributeType, System.Type[] ctorArgTypes, System.Object[] ctorArgs, System.String[] namedArgFieldNames, System.Object[] namedArgValues) { return default(Mono.CodeGeneration.CodeCustomAttribute); }
    public void Generate() { }
    public Mono.CodeGeneration.CodeArgumentReference GetArg(int n) { return default(Mono.CodeGeneration.CodeArgumentReference); }
    public Mono.CodeGeneration.CodeArgumentReference GetThis() { return default(Mono.CodeGeneration.CodeArgumentReference); }
    public string PrintCode() { return default(string); }
    public void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
    public void UpdatePropertyInfo(System.Type type) { }
  }
  public partial class CodePropertyReference : Mono.CodeGeneration.CodeValueReference {
    public CodePropertyReference(Mono.CodeGeneration.CodeExpression target, System.Reflection.PropertyInfo property) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateSet(System.Reflection.Emit.ILGenerator gen, Mono.CodeGeneration.CodeExpression value) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeReturn : Mono.CodeGeneration.CodeStatement {
    internal CodeReturn() { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeSelect : Mono.CodeGeneration.CodeStatement {
    public CodeSelect() { }
    public void AddCase(Mono.CodeGeneration.CodeExpression condition, Mono.CodeGeneration.CodeBlock block) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeSelfIncrement : Mono.CodeGeneration.CodeExpression {
    public CodeSelfIncrement(Mono.CodeGeneration.CodeValueReference exp) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public abstract partial class CodeStatement : Mono.CodeGeneration.CodeItem {
    protected CodeStatement() { }
  }
  public partial class CodeSub : Mono.CodeGeneration.CodeArithmeticOperation {
    public CodeSub(Mono.CodeGeneration.CodeExpression exp1, Mono.CodeGeneration.CodeExpression exp2) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
  }
  public partial class CodeSubstractOne : Mono.CodeGeneration.CodeExpression {
    public CodeSubstractOne(Mono.CodeGeneration.CodeExpression exp) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeTry : Mono.CodeGeneration.CodeStatement {
    public CodeTry() { }
    public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Mono.CodeGeneration.CodeVariableDeclaration, Mono.CodeGeneration.CodeBlock>> CatchBlocks { get { return default(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<Mono.CodeGeneration.CodeVariableDeclaration, Mono.CodeGeneration.CodeBlock>>); } }
    public Mono.CodeGeneration.CodeBlock FinallyBlock { get { return default(Mono.CodeGeneration.CodeBlock); } set { } }
    public Mono.CodeGeneration.CodeBlock TryBlock { get { return default(Mono.CodeGeneration.CodeBlock); } set { } }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public abstract partial class CodeValueReference : Mono.CodeGeneration.CodeExpression {
    protected CodeValueReference() { }
    public abstract void GenerateSet(System.Reflection.Emit.ILGenerator gen, Mono.CodeGeneration.CodeExpression value);
  }
  public partial class CodeVariableDeclaration : Mono.CodeGeneration.CodeStatement {
    public CodeVariableDeclaration(System.Type type, string name) { }
    public Mono.CodeGeneration.CodeVariableReference Variable { get { return default(Mono.CodeGeneration.CodeVariableReference); } }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeVariableReference : Mono.CodeGeneration.CodeValueReference {
    public CodeVariableReference(System.Type type, string name) { }
    public string Name { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void GenerateSet(System.Reflection.Emit.ILGenerator gen, Mono.CodeGeneration.CodeExpression value) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeWhen : Mono.CodeGeneration.CodeExpression {
    public CodeWhen(Mono.CodeGeneration.CodeExpression condition, Mono.CodeGeneration.CodeExpression trueResult, Mono.CodeGeneration.CodeExpression falseResult) { }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override System.Type GetResultType() { return default(System.Type); }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeWhile : Mono.CodeGeneration.CodeStatement {
    public CodeWhile(Mono.CodeGeneration.CodeExpression condition) { }
    public Mono.CodeGeneration.CodeBlock WhileBlock { get { return default(Mono.CodeGeneration.CodeBlock); } set { } }
    public override void Generate(System.Reflection.Emit.ILGenerator gen) { }
    public override void PrintCode(Mono.CodeGeneration.CodeWriter cp) { }
  }
  public partial class CodeWriter {
    public CodeWriter(System.IO.TextWriter tw) { }
    public Mono.CodeGeneration.CodeWriter BeginLine() { return default(Mono.CodeGeneration.CodeWriter); }
    public Mono.CodeGeneration.CodeWriter EndLine() { return default(Mono.CodeGeneration.CodeWriter); }
    public void Indent() { }
    public void Unindent() { }
    public Mono.CodeGeneration.CodeWriter Write(string s) { return default(Mono.CodeGeneration.CodeWriter); }
    public Mono.CodeGeneration.CodeWriter WriteLine(string s) { return default(Mono.CodeGeneration.CodeWriter); }
    public Mono.CodeGeneration.CodeWriter WriteLineInd(string s) { return default(Mono.CodeGeneration.CodeWriter); }
    public Mono.CodeGeneration.CodeWriter WriteLineUnind(string s) { return default(Mono.CodeGeneration.CodeWriter); }
  }
  public partial class Exp {
    internal Exp() { }
    public static Mono.CodeGeneration.CodeExpression And(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression And(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2, Mono.CodeGeneration.CodeExpression e3) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Call(Mono.CodeGeneration.CodeExpression target, Mono.CodeGeneration.CodeMethod method, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Call(Mono.CodeGeneration.CodeExpression target, System.Reflection.MethodInfo method, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Call(Mono.CodeGeneration.CodeExpression target, string name, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Call(Mono.CodeGeneration.CodeMethod method, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Call(System.Reflection.MethodInfo method, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Call(System.Type type, string name, params Mono.CodeGeneration.CodeExpression[] parameters) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeValueReference Inc(Mono.CodeGeneration.CodeValueReference e) { return default(Mono.CodeGeneration.CodeValueReference); }
    public static Mono.CodeGeneration.CodeExpression Literal(object ob) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Literal(string ob) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression New(System.Type type, params Mono.CodeGeneration.CodeExpression[] pars) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression NewArray(System.Type type, Mono.CodeGeneration.CodeExpression size) { return default(Mono.CodeGeneration.CodeExpression); }
    public static Mono.CodeGeneration.CodeExpression Or(Mono.CodeGeneration.CodeExpression e1, Mono.CodeGeneration.CodeExpression e2) { return default(Mono.CodeGeneration.CodeExpression); }
  }
}
namespace Mono.Security.Protocol.Ntlm {
  public partial class ChallengeResponse : System.IDisposable {
    public ChallengeResponse() { }
    public ChallengeResponse(string password, System.Byte[] challenge) { }
    public System.Byte[] Challenge { get { return default(System.Byte[]); } set { } }
    public System.Byte[] LM { get { return default(System.Byte[]); } }
    public System.Byte[] LMSessionKey { get { return default(System.Byte[]); } }
    public System.Byte[] NT { get { return default(System.Byte[]); } }
    public string Password { get { return default(string); } set { } }
    public void Dispose() { }
    ~ChallengeResponse() { }
  }
  public abstract partial class MessageBase {
    protected MessageBase(int messageType) { }
    protected MessageBase(int messageType, Mono.Security.Protocol.Ntlm.NtlmVersion version) { }
    public Mono.Security.Protocol.Ntlm.NtlmFlags Flags { get { return default(Mono.Security.Protocol.Ntlm.NtlmFlags); } set { } }
    public System.Byte[] OSVersion { get { return default(System.Byte[]); } set { } }
    public int Type { get { return default(int); } }
    public Mono.Security.Protocol.Ntlm.NtlmVersion Version { get { return default(Mono.Security.Protocol.Ntlm.NtlmVersion); } }
    protected bool CheckHeader(System.Byte[] message) { return default(bool); }
    protected virtual void Decode(System.Byte[] message) { }
    public abstract System.Byte[] GetBytes();
    protected System.Byte[] PrepareMessage(int messageSize) { return default(System.Byte[]); }
  }
  [System.FlagsAttribute]
  public enum NtlmFlags {
    Negotiate128 = 536870912,
    Negotiate56 = -2147483648,
    NegotiateAlwaysSign = 32768,
    NegotiateAnonymous = 2048,
    NegotiateDatagramStyle = 64,
    NegotiateDomainSupplied = 4096,
    NegotiateKeyExchange = 1073741824,
    NegotiateLm = 128,
    NegotiateNtlm = 512,
    NegotiateNtlm2Key = 524288,
    NegotiateOem = 2,
    NegotiateSeal = 32,
    NegotiateSign = 16,
    NegotiateUnicode = 1,
    NegotiateWorkstationSupplied = 8192,
    RequestTarget = 4,
  }
  public partial class NtlmTargetInformation {
    public NtlmTargetInformation() { }
    public string DnsDomainName { get { return default(string); } set { } }
    public string DnsHostName { get { return default(string); } set { } }
    public string DomainName { get { return default(string); } set { } }
    public string ServerName { get { return default(string); } set { } }
    public void Decode(System.Byte[] bytes, int length, int offset) { }
    public System.Byte[] ToBytes() { return default(System.Byte[]); }
  }
  public enum NtlmVersion {
    Version1 = 0,
    Version2 = 1,
    Version3 = 2,
  }
  public partial class Type1Message : Mono.Security.Protocol.Ntlm.MessageBase {
    public Type1Message() : base (default(int)) { }
    public Type1Message(Mono.Security.Protocol.Ntlm.NtlmVersion version) : base (default(int)) { }
    public Type1Message(System.Byte[] message) : base (default(int)) { }
    public Type1Message(System.Byte[] message, Mono.Security.Protocol.Ntlm.NtlmVersion version) : base (default(int)) { }
    public string Domain { get { return default(string); } set { } }
    public string Host { get { return default(string); } set { } }
    protected override void Decode(System.Byte[] message) { }
    public override System.Byte[] GetBytes() { return default(System.Byte[]); }
  }
  public partial class Type2Message : Mono.Security.Protocol.Ntlm.MessageBase {
    public Type2Message() : base (default(int)) { }
    public Type2Message(Mono.Security.Protocol.Ntlm.NtlmVersion version) : base (default(int)) { }
    public Type2Message(System.Byte[] message) : base (default(int)) { }
    public Type2Message(System.Byte[] message, Mono.Security.Protocol.Ntlm.NtlmVersion version) : base (default(int)) { }
    public System.Byte[] Context { get { return default(System.Byte[]); } set { } }
    public System.Byte[] Nonce { get { return default(System.Byte[]); } set { } }
    public Mono.Security.Protocol.Ntlm.NtlmTargetInformation Target { get { return default(Mono.Security.Protocol.Ntlm.NtlmTargetInformation); } }
    public string TargetName { get { return default(string); } set { } }
    protected override void Decode(System.Byte[] message) { }
    ~Type2Message() { }
    public override System.Byte[] GetBytes() { return default(System.Byte[]); }
  }
  public partial class Type3Message : Mono.Security.Protocol.Ntlm.MessageBase {
    public Type3Message() : base (default(int)) { }
    public Type3Message(Mono.Security.Protocol.Ntlm.NtlmVersion version) : base (default(int)) { }
    public Type3Message(System.Byte[] message) : base (default(int)) { }
    public Type3Message(System.Byte[] message, Mono.Security.Protocol.Ntlm.NtlmVersion version) : base (default(int)) { }
    public System.Byte[] Challenge { get { return default(System.Byte[]); } set { } }
    public string Domain { get { return default(string); } set { } }
    public string Host { get { return default(string); } set { } }
    public System.Byte[] LM { get { return default(System.Byte[]); } }
    public System.Byte[] NT { get { return default(System.Byte[]); } }
    public string Password { get { return default(string); } set { } }
    public string Username { get { return default(string); } set { } }
    protected override void Decode(System.Byte[] message) { }
    ~Type3Message() { }
    public override System.Byte[] GetBytes() { return default(System.Byte[]); }
  }
}
namespace Mono.Security.Protocol.Tls {
  public delegate System.Security.Cryptography.X509Certificates.X509Certificate CertificateSelectionCallback(System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection serverRequestedCertificates);
  public delegate bool CertificateValidationCallback(System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Int32[] certificateErrors);
  public delegate Mono.Security.Protocol.Tls.ValidationResult CertificateValidationCallback2(Mono.Security.X509.X509CertificateCollection collection);
  public enum CipherAlgorithmType {
    Des = 0,
    None = 1,
    Rc2 = 2,
    Rc4 = 3,
    Rijndael = 4,
    SkipJack = 5,
    TripleDes = 6,
  }
  public enum ExchangeAlgorithmType {
    DiffieHellman = 0,
    Fortezza = 1,
    None = 2,
    RsaKeyX = 3,
    RsaSign = 4,
  }
  public enum HashAlgorithmType {
    Md5 = 0,
    None = 1,
    Sha1 = 2,
  }
  public delegate System.Security.Cryptography.AsymmetricAlgorithm PrivateKeySelectionCallback(System.Security.Cryptography.X509Certificates.X509Certificate certificate, string targetHost);
  public enum SecurityCompressionType {
    None = 0,
    Zlib = 1,
  }
  [System.FlagsAttribute]
  public enum SecurityProtocolType {
    Default = -1073741824,
    Ssl2 = 12,
    Ssl3 = 48,
    Tls = 192,
  }
  public partial class SslClientStream : Mono.Security.Protocol.Tls.SslStreamBase {
    public SslClientStream(System.IO.Stream stream, string targetHost, bool ownsStream) : base (default(System.IO.Stream), default(bool)) { }
    public SslClientStream(System.IO.Stream stream, string targetHost, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType) : base (default(System.IO.Stream), default(bool)) { }
    public SslClientStream(System.IO.Stream stream, string targetHost, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) : base (default(System.IO.Stream), default(bool)) { }
    public SslClientStream(System.IO.Stream stream, string targetHost, System.Security.Cryptography.X509Certificates.X509Certificate clientCertificate) : base (default(System.IO.Stream), default(bool)) { }
    public SslClientStream(System.IO.Stream stream, string targetHost, System.Security.Cryptography.X509Certificates.X509CertificateCollection clientCertificates) : base (default(System.IO.Stream), default(bool)) { }
    public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { return default(System.Security.Cryptography.X509Certificates.X509CertificateCollection); } }
    public Mono.Security.Protocol.Tls.CertificateSelectionCallback ClientCertSelectionDelegate { get { return default(Mono.Security.Protocol.Tls.CertificateSelectionCallback); } set { } }
    public Mono.Security.Protocol.Tls.PrivateKeySelectionCallback PrivateKeyCertSelectionDelegate { get { return default(Mono.Security.Protocol.Tls.PrivateKeySelectionCallback); } set { } }
    public System.Security.Cryptography.X509Certificates.X509Certificate SelectedClientCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public Mono.Security.Protocol.Tls.CertificateValidationCallback ServerCertValidationDelegate { get { return default(Mono.Security.Protocol.Tls.CertificateValidationCallback); } set { } }
    public event Mono.Security.Protocol.Tls.CertificateValidationCallback2 ServerCertValidation2 { add { } remove { } }
    protected override void Dispose(bool disposing) { }
    ~SslClientStream() { }
  }
  public partial class SslServerStream : Mono.Security.Protocol.Tls.SslStreamBase {
    public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate) : base (default(System.IO.Stream), default(bool)) { }
    public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool ownsStream) : base (default(System.IO.Stream), default(bool)) { }
    public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType) : base (default(System.IO.Stream), default(bool)) { }
    public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool requestClientCertificate, bool ownsStream) : base (default(System.IO.Stream), default(bool)) { }
    public SslServerStream(System.IO.Stream stream, System.Security.Cryptography.X509Certificates.X509Certificate serverCertificate, bool clientCertificateRequired, bool requestClientCertificate, bool ownsStream, Mono.Security.Protocol.Tls.SecurityProtocolType securityProtocolType) : base (default(System.IO.Stream), default(bool)) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate ClientCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public Mono.Security.Protocol.Tls.CertificateValidationCallback ClientCertValidationDelegate { get { return default(Mono.Security.Protocol.Tls.CertificateValidationCallback); } set { } }
    public Mono.Security.Protocol.Tls.PrivateKeySelectionCallback PrivateKeyCertSelectionDelegate { get { return default(Mono.Security.Protocol.Tls.PrivateKeySelectionCallback); } set { } }
    public event Mono.Security.Protocol.Tls.CertificateValidationCallback2 ClientCertValidation2 { add { } remove { } }
    protected override void Dispose(bool disposing) { }
    ~SslServerStream() { }
  }
  public abstract partial class SslStreamBase : System.IO.Stream, System.IDisposable {
    protected SslStreamBase(System.IO.Stream stream, bool ownsStream) { }
    public override bool CanRead { get { return default(bool); } }
    public override bool CanSeek { get { return default(bool); } }
    public override bool CanWrite { get { return default(bool); } }
    public bool CheckCertRevocationStatus { get { return default(bool); } set { } }
    public Mono.Security.Protocol.Tls.CipherAlgorithmType CipherAlgorithm { get { return default(Mono.Security.Protocol.Tls.CipherAlgorithmType); } }
    public int CipherStrength { get { return default(int); } }
    public Mono.Security.Protocol.Tls.HashAlgorithmType HashAlgorithm { get { return default(Mono.Security.Protocol.Tls.HashAlgorithmType); } }
    public int HashStrength { get { return default(int); } }
    public Mono.Security.Protocol.Tls.ExchangeAlgorithmType KeyExchangeAlgorithm { get { return default(Mono.Security.Protocol.Tls.ExchangeAlgorithmType); } }
    public int KeyExchangeStrength { get { return default(int); } }
    public override long Length { get { return default(long); } }
    public override long Position { get { return default(long); } set { } }
    public Mono.Security.Protocol.Tls.SecurityProtocolType SecurityProtocol { get { return default(Mono.Security.Protocol.Tls.SecurityProtocolType); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate ServerCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate); } }
    public override System.IAsyncResult BeginRead(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override System.IAsyncResult BeginWrite(System.Byte[] buffer, int offset, int count, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public override void Close() { }
    protected override void Dispose(bool disposing) { }
    public override int EndRead(System.IAsyncResult asyncResult) { return default(int); }
    public override void EndWrite(System.IAsyncResult asyncResult) { }
    ~SslStreamBase() { }
    public override void Flush() { }
    public int Read(System.Byte[] buffer) { return default(int); }
    public override int Read(System.Byte[] buffer, int offset, int count) { return default(int); }
    public override long Seek(long offset, System.IO.SeekOrigin origin) { return default(long); }
    public override void SetLength(long value) { }
    public void Write(System.Byte[] buffer) { }
    public override void Write(System.Byte[] buffer, int offset, int count) { }
  }
  public partial class ValidationResult {
    public ValidationResult(bool trusted, bool user_denied, int error_code) { }
    public int ErrorCode { get { return default(int); } }
    public bool Trusted { get { return default(bool); } }
    public bool UserDenied { get { return default(bool); } }
  }
}
namespace System.Collections.Generic {
  public partial class KeyedByTypeCollection<TItem> : System.Collections.ObjectModel.KeyedCollection<System.Type, TItem> {
    public KeyedByTypeCollection() { }
    public KeyedByTypeCollection(System.Collections.Generic.IEnumerable<TItem> items) { }
    public T Find<T>() { return default(T); }
    public System.Collections.ObjectModel.Collection<T> FindAll<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    protected override System.Type GetKeyForItem(TItem item) { return default(System.Type); }
    protected override void InsertItem(int index, TItem kind) { }
    public T Remove<T>() { return default(T); }
    public System.Collections.ObjectModel.Collection<T> RemoveAll<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    protected override void SetItem(int index, TItem kind) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class SynchronizedCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public SynchronizedCollection() { }
    public SynchronizedCollection(object syncRoot) { }
    public SynchronizedCollection(object syncRoot, params T[] list) { }
    public SynchronizedCollection(object syncRoot, System.Collections.Generic.IEnumerable<T> list) { }
    public SynchronizedCollection(object syncRoot, System.Collections.Generic.List<T> list, bool makeCopy) { }
    public int Count { get { return default(int); } }
    public T this[int index] { get { return default(T); } set { } }
    protected System.Collections.Generic.List<T> Items { get { return default(System.Collections.Generic.List<T>); } }
    public object SyncRoot { get { return default(object); } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public void Add(T item) { }
    public void Clear() { }
    protected virtual void ClearItems() { }
    public bool Contains(T item) { return default(bool); }
    public void CopyTo(T[] array, int index) { }
    [System.MonoTODOAttribute("Should be synchronized enumerator?")]
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    public int IndexOf(T item) { return default(int); }
    public void Insert(int index, T item) { }
    protected virtual void InsertItem(int index, T item) { }
    [System.MonoTODOAttribute("should we lock and remove item without invoking RemoveItem() instead?")]
    public bool Remove(T item) { return default(bool); }
    public void RemoveAt(int index) { }
    protected virtual void RemoveItem(int index) { }
    protected virtual void SetItem(int index, T item) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public abstract partial class SynchronizedKeyedCollection<K, T> : System.Collections.Generic.SynchronizedCollection<T> {
    protected SynchronizedKeyedCollection() { }
    protected SynchronizedKeyedCollection(object syncRoot) { }
    protected SynchronizedKeyedCollection(object syncRoot, System.Collections.Generic.IEqualityComparer<K> comparer) { }
    protected SynchronizedKeyedCollection(object syncRoot, System.Collections.Generic.IEqualityComparer<K> comparer, int capacity) { }
    protected System.Collections.Generic.IDictionary<K, T> Dictionary { get { return default(System.Collections.Generic.IDictionary<K, T>); } }
    public T this[K key] { get { return default(T); } }
    protected void ChangeItemKey(T item, K newKey) { }
    [System.MonoTODOAttribute("This lock is not an atomic.")]
    protected override void ClearItems() { }
    public bool Contains(K key) { return default(bool); }
    protected abstract K GetKeyForItem(T item);
    [System.MonoTODOAttribute("This lock is not an atomic.")]
    protected override void InsertItem(int index, T item) { }
    public bool Remove(K key) { return default(bool); }
    [System.MonoTODOAttribute("This lock is not an atomic.")]
    protected override void RemoveItem(int index) { }
    [System.MonoTODOAttribute("This lock is not an atomic.")]
    protected override void SetItem(int index, T item) { }
  }
  [System.Runtime.InteropServices.ComVisibleAttribute(false)]
  public partial class SynchronizedReadOnlyCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList {
    public SynchronizedReadOnlyCollection() { }
    public SynchronizedReadOnlyCollection(object sync_root) { }
    public SynchronizedReadOnlyCollection(object sync_root, params T[] list) { }
    public SynchronizedReadOnlyCollection(object sync_root, System.Collections.Generic.IEnumerable<T> list) { }
    public SynchronizedReadOnlyCollection(object sync_root, System.Collections.Generic.List<T> list, bool make_copy) { }
    public int Count { get { return default(int); } }
    public T this[int index] { get { return default(T); } }
    protected System.Collections.Generic.IList<T> Items { get { return default(System.Collections.Generic.IList<T>); } }
    bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { return default(bool); } }
    T System.Collections.Generic.IList<T>.this[int index] { get { return default(T); } set { } }
    bool System.Collections.ICollection.IsSynchronized { get { return default(bool); } }
    object System.Collections.ICollection.SyncRoot { get { return default(object); } }
    bool System.Collections.IList.IsFixedSize { get { return default(bool); } }
    bool System.Collections.IList.IsReadOnly { get { return default(bool); } }
    object System.Collections.IList.this[int index] { get { return default(object); } set { } }
    public bool Contains(T value) { return default(bool); }
    public void CopyTo(T[] array, int index) { }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<T>); }
    public int IndexOf(T value) { return default(int); }
    void System.Collections.Generic.ICollection<T>.Add(T value) { }
    void System.Collections.Generic.ICollection<T>.Clear() { }
    bool System.Collections.Generic.ICollection<T>.Remove(T value) { return default(bool); }
    void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
    void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    int System.Collections.IList.Add(object value) { return default(int); }
    void System.Collections.IList.Clear() { }
    bool System.Collections.IList.Contains(object value) { return default(bool); }
    int System.Collections.IList.IndexOf(object value) { return default(int); }
    void System.Collections.IList.Insert(int index, object value) { }
    void System.Collections.IList.Remove(object value) { }
    void System.Collections.IList.RemoveAt(int index) { }
  }
}
namespace System.IO {
  public partial class PipeException : System.IO.IOException {
    public PipeException() { }
    protected PipeException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PipeException(string message) { }
    public PipeException(string message, System.Exception inner) { }
    public PipeException(string message, int errorCode) { }
    public virtual int ErrorCode { get { return default(int); } }
  }
}
namespace System.ServiceModel {
  public partial class ActionNotSupportedException : System.ServiceModel.CommunicationException {
    public ActionNotSupportedException() { }
    protected ActionNotSupportedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ActionNotSupportedException(string msg) { }
    public ActionNotSupportedException(string msg, System.Exception inner) { }
  }
  public partial class AddressAccessDeniedException : System.ServiceModel.CommunicationException {
    public AddressAccessDeniedException() { }
    protected AddressAccessDeniedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public AddressAccessDeniedException(string msg) { }
    public AddressAccessDeniedException(string msg, System.Exception inner) { }
  }
  public partial class AddressAlreadyInUseException : System.ServiceModel.CommunicationException {
    public AddressAlreadyInUseException() { }
    protected AddressAlreadyInUseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public AddressAlreadyInUseException(string msg) { }
    public AddressAlreadyInUseException(string msg, System.Exception inner) { }
  }
  public enum AddressFilterMode {
    Any = 2,
    Exact = 0,
    Prefix = 1,
  }
  public enum AuditLevel {
    Failure = 2,
    None = 0,
    Success = 1,
    SuccessOrFailure = 3,
  }
  public enum AuditLogLocation {
    Application = 1,
    Default = 0,
    Security = 2,
  }
  public partial class BasicHttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public BasicHttpBinding() { }
    public BasicHttpBinding(System.ServiceModel.BasicHttpSecurityMode securityMode) { }
    public BasicHttpBinding(string configurationName) { }
    public bool AllowCookies { get { return default(bool); } set { } }
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    public int MaxBufferSize { get { return default(int); } set { } }
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public System.ServiceModel.WSMessageEncoding MessageEncoding { get { return default(System.ServiceModel.WSMessageEncoding); } set { } }
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.BasicHttpSecurity Security { get { return default(System.ServiceModel.BasicHttpSecurity); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public enum BasicHttpMessageCredentialType {
    Certificate = 1,
    UserName = 0,
  }
  [System.MonoTODOAttribute]
  public sealed partial class BasicHttpMessageSecurity {
    internal BasicHttpMessageSecurity() { }
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public System.ServiceModel.BasicHttpMessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.BasicHttpMessageCredentialType); } set { } }
  }
  public sealed partial class BasicHttpSecurity {
    internal BasicHttpSecurity() { }
    public System.ServiceModel.BasicHttpMessageSecurity Message { get { return default(System.ServiceModel.BasicHttpMessageSecurity); } }
    public System.ServiceModel.BasicHttpSecurityMode Mode { get { return default(System.ServiceModel.BasicHttpSecurityMode); } set { } }
    public System.ServiceModel.HttpTransportSecurity Transport { get { return default(System.ServiceModel.HttpTransportSecurity); } }
  }
  public enum BasicHttpSecurityMode {
    Message = 2,
    None = 0,
    Transport = 1,
    TransportCredentialOnly = 4,
    TransportWithMessageCredential = 3,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class CallbackBehaviorAttribute : System.Attribute, System.ServiceModel.Description.IEndpointBehavior {
    public CallbackBehaviorAttribute() { }
    [System.MonoTODOAttribute]
    public bool AutomaticSessionShutdown { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.ConcurrencyMode ConcurrencyMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.ConcurrencyMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool IgnoreExtensionDataObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool IncludeExceptionDetailInFaults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int MaxItemsInObjectGraph { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Transactions.IsolationLevel TransactionIsolationLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Transactions.IsolationLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public string TransactionTimeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool UseSynchronizationContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool ValidateMustUnderstand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.EndpointDispatcher dispatcher) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint) { }
  }
  public abstract partial class ChannelFactory : System.ServiceModel.Channels.CommunicationObject, System.IDisposable, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject {
    protected ChannelFactory() { }
    public System.ServiceModel.Description.ClientCredentials Credentials { get { return default(System.ServiceModel.Description.ClientCredentials); } }
    protected internal override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { return default(System.ServiceModel.Description.ServiceEndpoint); } }
    protected virtual void ApplyConfiguration(string endpointConfig) { }
    protected abstract System.ServiceModel.Description.ServiceEndpoint CreateDescription();
    protected virtual System.ServiceModel.Channels.IChannelFactory CreateFactory() { return default(System.ServiceModel.Channels.IChannelFactory); }
    protected void EnsureOpened() { }
    public T GetProperty<T>() where T : class { return default(T); }
    protected void InitializeEndpoint(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected void InitializeEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    protected void InitializeEndpoint(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected override void OnEndOpen(System.IAsyncResult result) { }
    protected override void OnOpen(System.TimeSpan timeout) { }
    protected override void OnOpened() { }
    protected override void OnOpening() { }
    void System.IDisposable.Dispose() { }
  }
  public partial class ChannelFactory<TChannel> : System.ServiceModel.ChannelFactory, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.Channels.IChannelFactory<TChannel>, System.ServiceModel.ICommunicationObject {
    public ChannelFactory() { }
    public ChannelFactory(System.ServiceModel.Channels.Binding binding) { }
    public ChannelFactory(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public ChannelFactory(System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
    public ChannelFactory(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public ChannelFactory(string endpointConfigurationName) { }
    public ChannelFactory(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ChannelFactory(System.Type type) { }
    public TChannel CreateChannel() { return default(TChannel); }
    public static TChannel CreateChannel(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public static TChannel CreateChannel(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public virtual TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    protected static TChannel CreateChannel(string endpointConfigurationName) { return default(TChannel); }
    protected override System.ServiceModel.Description.ServiceEndpoint CreateDescription() { return default(System.ServiceModel.Description.ServiceEndpoint); }
  }
  public partial class ChannelTerminatedException : System.ServiceModel.CommunicationException {
    public ChannelTerminatedException() { }
    protected ChannelTerminatedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ChannelTerminatedException(string msg) { }
    public ChannelTerminatedException(string msg, System.Exception inner) { }
  }
  [System.MonoTODOAttribute("It somehow rejects classes, but dunno how we can do that besides our code wise.")]
  public abstract partial class ClientBase<TChannel> : System.IDisposable, System.ServiceModel.ICommunicationObject where TChannel : class {
    protected ClientBase() { }
    protected ClientBase(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ClientBase(System.ServiceModel.InstanceContext instance) { }
    protected ClientBase(System.ServiceModel.InstanceContext instance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ClientBase(System.ServiceModel.InstanceContext instance, string endpointConfigurationName) { }
    protected ClientBase(System.ServiceModel.InstanceContext instance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ClientBase(System.ServiceModel.InstanceContext instance, string endpointConfigurationName, string remoteAddress) { }
    protected ClientBase(string endpointConfigurationName) { }
    protected ClientBase(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    protected ClientBase(string endpointConfigurationName, string remoteAddress) { }
    protected TChannel Channel { get { return default(TChannel); } }
    public System.ServiceModel.ChannelFactory<TChannel> ChannelFactory { get { return default(System.ServiceModel.ChannelFactory<TChannel>); } }
    public System.ServiceModel.Description.ClientCredentials ClientCredentials { get { return default(System.ServiceModel.Description.ClientCredentials); } }
    public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { return default(System.ServiceModel.Description.ServiceEndpoint); } }
    public System.ServiceModel.IClientChannel InnerChannel { get { return default(System.ServiceModel.IClientChannel); } }
    public System.ServiceModel.CommunicationState State { get { return default(System.ServiceModel.CommunicationState); } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Closed { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Closing { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Faulted { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Opened { add { } remove { } }
    event System.EventHandler System.ServiceModel.ICommunicationObject.Opening { add { } remove { } }
    public void Abort() { }
    public void Close() { }
    protected virtual TChannel CreateChannel() { return default(TChannel); }
    public void DisplayInitializationUI() { }
    protected T GetDefaultValueForInitialization<T>() { return default(T); }
    protected void InvokeAsync(System.ServiceModel.ClientBase<TChannel>.BeginOperationDelegate beginOperationDelegate, System.Object[] inValues, System.ServiceModel.ClientBase<TChannel>.EndOperationDelegate endOperationDelegate, System.Threading.SendOrPostCallback operationCompletedCallback, object userState) { }
    public void Open() { }
    void System.IDisposable.Dispose() { }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    void System.ServiceModel.ICommunicationObject.Close(System.TimeSpan timeout) { }
    void System.ServiceModel.ICommunicationObject.EndClose(System.IAsyncResult result) { }
    void System.ServiceModel.ICommunicationObject.EndOpen(System.IAsyncResult result) { }
    void System.ServiceModel.ICommunicationObject.Open(System.TimeSpan timeout) { }
    protected delegate System.IAsyncResult BeginOperationDelegate(System.Object[] inValues, System.AsyncCallback asyncCallback, object state);
    protected delegate System.Object[] EndOperationDelegate(System.IAsyncResult result);
    protected partial class InvokeAsyncCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
      internal InvokeAsyncCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
      public System.Object[] Results { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Object[]); } }
    }
  }
  [System.MonoTODOAttribute]
  public partial class ClientCredentialsSecurityTokenManager : System.IdentityModel.Selectors.SecurityTokenManager {
    public ClientCredentialsSecurityTokenManager(System.ServiceModel.Description.ClientCredentials credentials) { }
    public System.ServiceModel.Description.ClientCredentials ClientCredentials { get { return default(System.ServiceModel.Description.ClientCredentials); } }
    [System.MonoTODOAttribute]
    public override System.IdentityModel.Selectors.SecurityTokenAuthenticator CreateSecurityTokenAuthenticator(System.IdentityModel.Selectors.SecurityTokenRequirement requirement, out System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { outOfBandTokenResolver = default(System.IdentityModel.Selectors.SecurityTokenResolver); return default(System.IdentityModel.Selectors.SecurityTokenAuthenticator); }
    [System.MonoTODOAttribute]
    public override System.IdentityModel.Selectors.SecurityTokenProvider CreateSecurityTokenProvider(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { return default(System.IdentityModel.Selectors.SecurityTokenProvider); }
    public override System.IdentityModel.Selectors.SecurityTokenSerializer CreateSecurityTokenSerializer(System.IdentityModel.Selectors.SecurityTokenVersion version) { return default(System.IdentityModel.Selectors.SecurityTokenSerializer); }
    protected System.IdentityModel.Selectors.SecurityTokenSerializer CreateSecurityTokenSerializer(System.ServiceModel.Security.SecurityVersion version) { return default(System.IdentityModel.Selectors.SecurityTokenSerializer); }
    protected internal bool IsIssuedSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { return default(bool); }
  }
  public partial class CommunicationException : System.SystemException {
    public CommunicationException() { }
    protected CommunicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CommunicationException(string msg) { }
    public CommunicationException(string msg, System.Exception inner) { }
  }
  public partial class CommunicationObjectAbortedException : System.ServiceModel.CommunicationException {
    public CommunicationObjectAbortedException() { }
    protected CommunicationObjectAbortedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CommunicationObjectAbortedException(string msg) { }
    public CommunicationObjectAbortedException(string msg, System.Exception inner) { }
  }
  public partial class CommunicationObjectFaultedException : System.ServiceModel.CommunicationException {
    public CommunicationObjectFaultedException() { }
    protected CommunicationObjectFaultedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public CommunicationObjectFaultedException(string msg) { }
    public CommunicationObjectFaultedException(string msg, System.Exception inner) { }
  }
  public enum CommunicationState {
    Closed = 4,
    Closing = 3,
    Created = 0,
    Faulted = 5,
    Opened = 2,
    Opening = 1,
  }
  public enum ConcurrencyMode {
    Multiple = 2,
    Reentrant = 1,
    Single = 0,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1092), Inherited=false)]
  public sealed partial class DataContractFormatAttribute : System.Attribute {
    public DataContractFormatAttribute() { }
    public System.ServiceModel.OperationFormatStyle Style { get { return default(System.ServiceModel.OperationFormatStyle); } set { } }
  }
  public enum DeadLetterQueue {
    Custom = 2,
    None = 0,
    System = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true, Inherited=false)]
  [System.MonoTODOAttribute]
  public sealed partial class DeliveryRequirementsAttribute : System.Attribute, System.ServiceModel.Description.IContractBehavior, System.ServiceModel.Description.IContractBehaviorAttribute {
    public DeliveryRequirementsAttribute() { }
    public System.ServiceModel.QueuedDeliveryRequirementsMode QueuedDeliveryRequirements { get { return default(System.ServiceModel.QueuedDeliveryRequirementsMode); } set { } }
    public bool RequireOrderedDelivery { get { return default(bool); } set { } }
    public System.Type TargetContract { get { return default(System.Type); } set { } }
    void System.ServiceModel.Description.IContractBehavior.AddBindingParameters(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IContractBehavior.ApplyClientBehavior(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime proxy) { }
    void System.ServiceModel.Description.IContractBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.DispatchRuntime dispatch) { }
    void System.ServiceModel.Description.IContractBehavior.Validate(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  public partial class DnsEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public DnsEndpointIdentity(System.IdentityModel.Claims.Claim identity) { }
    public DnsEndpointIdentity(string dns) { }
  }
  public partial class DuplexChannelFactory<TChannel> : System.ServiceModel.ChannelFactory<TChannel> {
    public DuplexChannelFactory(object callbackInstance) { }
    public DuplexChannelFactory(object callbackInstance, System.ServiceModel.Channels.Binding binding) { }
    public DuplexChannelFactory(object callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public DuplexChannelFactory(object callbackInstance, System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
    public DuplexChannelFactory(object callbackInstance, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public DuplexChannelFactory(object callbackInstance, string endpointConfigurationName) { }
    public DuplexChannelFactory(object callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { }
    public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    public DuplexChannelFactory(System.Type callbackInstanceType) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Channels.Binding binding) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, string endpointConfigurationName) { }
    public DuplexChannelFactory(System.Type callbackInstanceType, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
    public static TChannel CreateChannel(object callbackObject, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress) { return default(TChannel); }
    public static TChannel CreateChannel(object callbackObject, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress, System.Uri via) { return default(TChannel); }
    public static TChannel CreateChannel(object callbackObject, string endpointConfigurationName) { return default(TChannel); }
    public override TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance) { return default(TChannel); }
    public static TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress) { return default(TChannel); }
    public static TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress, System.Uri via) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.EndpointAddress address) { return default(TChannel); }
    public virtual TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.EndpointAddress address, System.Uri via) { return default(TChannel); }
    public static TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { return default(TChannel); }
  }
  public partial class DuplexClientBase<TChannel> : System.ServiceModel.ClientBase<TChannel> where TChannel : class {
    protected DuplexClientBase(object instance) { }
    protected DuplexClientBase(object instance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) { }
    protected DuplexClientBase(object instance, string configurationName) { }
    protected DuplexClientBase(object instance, string bindingConfigurationName, System.ServiceModel.EndpointAddress address) { }
    protected DuplexClientBase(object instance, string endpointConfigurationName, string remoteAddress) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext instance) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext instance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext instance, string configurationName) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext instance, string configurationName, System.ServiceModel.EndpointAddress address) { }
    protected DuplexClientBase(System.ServiceModel.InstanceContext instance, string endpointConfigurationName, string remoteAddress) { }
    public System.ServiceModel.IDuplexContextChannel InnerDuplexChannel { get { return default(System.ServiceModel.IDuplexContextChannel); } }
    protected override TChannel CreateChannel() { return default(TChannel); }
  }
  public partial class EndpointAddress {
    public EndpointAddress(string uri) { }
    public EndpointAddress(System.Uri uri, params System.ServiceModel.Channels.AddressHeader[] headers) { }
    public EndpointAddress(System.Uri uri, System.ServiceModel.EndpointIdentity identity, params System.ServiceModel.Channels.AddressHeader[] headers) { }
    public EndpointAddress(System.Uri uri, System.ServiceModel.EndpointIdentity identity, System.ServiceModel.Channels.AddressHeaderCollection headers) { }
    public EndpointAddress(System.Uri uri, System.ServiceModel.EndpointIdentity identity, System.ServiceModel.Channels.AddressHeaderCollection headers, System.Xml.XmlDictionaryReader metadataReader, System.Xml.XmlDictionaryReader extensionReader) { }
    public static System.Uri AnonymousUri { get { return default(System.Uri); } }
    public System.ServiceModel.Channels.AddressHeaderCollection Headers { get { return default(System.ServiceModel.Channels.AddressHeaderCollection); } }
    public System.ServiceModel.EndpointIdentity Identity { get { return default(System.ServiceModel.EndpointIdentity); } }
    public bool IsAnonymous { get { return default(bool); } }
    public bool IsNone { get { return default(bool); } }
    public static System.Uri NoneUri { get { return default(System.Uri); } }
    public System.Uri Uri { get { return default(System.Uri); } }
    [System.MonoTODOAttribute]
    public void ApplyTo(System.ServiceModel.Channels.Message message) { }
    public override bool Equals(object obj) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public System.Xml.XmlDictionaryReader GetReaderAtExtensions() { return default(System.Xml.XmlDictionaryReader); }
    public System.Xml.XmlDictionaryReader GetReaderAtMetadata() { return default(System.Xml.XmlDictionaryReader); }
    public static bool operator ==(System.ServiceModel.EndpointAddress address1, System.ServiceModel.EndpointAddress address2) { return default(bool); }
    public static bool operator !=(System.ServiceModel.EndpointAddress address1, System.ServiceModel.EndpointAddress address2) { return default(bool); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryReader reader) { return default(System.ServiceModel.EndpointAddress); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString ns) { return default(System.ServiceModel.EndpointAddress); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlReader reader) { return default(System.ServiceModel.EndpointAddress); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlReader reader, string localName, string ns) { return default(System.ServiceModel.EndpointAddress); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.Xml.XmlDictionaryReader reader) { return default(System.ServiceModel.EndpointAddress); }
    public static System.ServiceModel.EndpointAddress ReadFrom(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString ns) { return default(System.ServiceModel.EndpointAddress); }
    public override string ToString() { return default(string); }
    public void WriteContentsTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteContentsTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlWriter writer) { }
    public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryWriter writer, System.Xml.XmlDictionaryString localname, System.Xml.XmlDictionaryString ns) { }
    public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlWriter writer) { }
    public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlWriter writer, string localname, string ns) { }
  }
  [System.Xml.Serialization.XmlRootAttribute("EndpointReference", Namespace="http://www.w3.org/2005/08/addressing")]
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class EndpointAddress10 : System.Xml.Serialization.IXmlSerializable {
    internal EndpointAddress10() { }
    public static System.ServiceModel.EndpointAddress10 FromEndpointAddress(System.ServiceModel.EndpointAddress address) { return default(System.ServiceModel.EndpointAddress10); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet xmlSchemaSet) { return default(System.Xml.XmlQualifiedName); }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public System.ServiceModel.EndpointAddress ToEndpointAddress() { return default(System.ServiceModel.EndpointAddress); }
  }
  [System.Xml.Serialization.XmlRootAttribute("EndpointReference", Namespace="http://schemas.xmlsoap.org/ws/2004/08/addressing")]
  [System.Xml.Serialization.XmlSchemaProviderAttribute("GetSchema")]
  public partial class EndpointAddressAugust2004 : System.Xml.Serialization.IXmlSerializable {
    internal EndpointAddressAugust2004() { }
    public static System.ServiceModel.EndpointAddressAugust2004 FromEndpointAddress(System.ServiceModel.EndpointAddress address) { return default(System.ServiceModel.EndpointAddressAugust2004); }
    public static System.Xml.XmlQualifiedName GetSchema(System.Xml.Schema.XmlSchemaSet xmlSchemaSet) { return default(System.Xml.XmlQualifiedName); }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public System.ServiceModel.EndpointAddress ToEndpointAddress() { return default(System.ServiceModel.EndpointAddress); }
  }
  public partial class EndpointAddressBuilder {
    public EndpointAddressBuilder() { }
    public EndpointAddressBuilder(System.ServiceModel.EndpointAddress address) { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.AddressHeader> Headers { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.AddressHeader>); } }
    public System.ServiceModel.EndpointIdentity Identity { get { return default(System.ServiceModel.EndpointIdentity); } set { } }
    public System.Uri Uri { get { return default(System.Uri); } set { } }
    public System.Xml.XmlDictionaryReader GetReaderAtExtensions() { return default(System.Xml.XmlDictionaryReader); }
    public System.Xml.XmlDictionaryReader GetReaderAtMetadata() { return default(System.Xml.XmlDictionaryReader); }
    public void SetExtensionReader(System.Xml.XmlDictionaryReader reader) { }
    public void SetMetadataReader(System.Xml.XmlDictionaryReader reader) { }
    public System.ServiceModel.EndpointAddress ToEndpointAddress() { return default(System.ServiceModel.EndpointAddress); }
  }
  public abstract partial class EndpointIdentity {
    protected EndpointIdentity() { }
    public System.IdentityModel.Claims.Claim IdentityClaim { get { return default(System.IdentityModel.Claims.Claim); } }
    public static System.ServiceModel.EndpointIdentity CreateDnsIdentity(string dnsName) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateIdentity(System.IdentityModel.Claims.Claim identity) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateRsaIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateRsaIdentity(string publicKey) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateSpnIdentity(string spnName) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateUpnIdentity(string upnName) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateX509CertificateIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { return default(System.ServiceModel.EndpointIdentity); }
    public static System.ServiceModel.EndpointIdentity CreateX509CertificateIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 primaryCertificate, System.Security.Cryptography.X509Certificates.X509Certificate2Collection supportingCertificates) { return default(System.ServiceModel.EndpointIdentity); }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    protected void Initialize(System.IdentityModel.Claims.Claim claim) { }
    protected void Initialize(System.IdentityModel.Claims.Claim claim, System.Collections.Generic.IEqualityComparer<System.IdentityModel.Claims.Claim> comparer) { }
    public override string ToString() { return default(string); }
  }
  public partial class EndpointNotFoundException : System.ServiceModel.CommunicationException {
    public EndpointNotFoundException() { }
    protected EndpointNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public EndpointNotFoundException(string msg) { }
    public EndpointNotFoundException(string msg, System.Exception inner) { }
  }
  public sealed partial class EnvelopeVersion {
    internal EnvelopeVersion() { }
    public string NextDestinationActorValue { get { return default(string); } }
    public static System.ServiceModel.EnvelopeVersion None { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static System.ServiceModel.EnvelopeVersion Soap11 { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static System.ServiceModel.EnvelopeVersion Soap12 { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public System.String[] GetUltimateDestinationActorValues() { return default(System.String[]); }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class ExceptionDetail {
    public ExceptionDetail(System.Exception exception) { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string HelpLink { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public System.ServiceModel.ExceptionDetail InnerException { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.ExceptionDetail); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string StackTrace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class ExtensionCollection<T> : System.Collections.Generic.SynchronizedCollection<System.ServiceModel.IExtension<T>>, System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>, System.Collections.Generic.IEnumerable<System.ServiceModel.IExtension<T>>, System.Collections.IEnumerable, System.ServiceModel.IExtensionCollection<T> where T : System.ServiceModel.IExtensibleObject<T> {
    public ExtensionCollection(T owner) { }
    public ExtensionCollection(T owner, object syncRoot) { }
    bool System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>.IsReadOnly { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected override void ClearItems() { }
    public E Find<E>() { return default(E); }
    public System.Collections.ObjectModel.Collection<E> FindAll<E>() { return default(System.Collections.ObjectModel.Collection<E>); }
    [System.MonoTODOAttribute]
    protected override void InsertItem(int index, System.ServiceModel.IExtension<T> item) { }
    [System.MonoTODOAttribute]
    protected override void RemoveItem(int index) { }
    [System.MonoTODOAttribute]
    protected override void SetItem(int index, System.ServiceModel.IExtension<T> item) { }
  }
  public partial class FaultCode {
    public FaultCode(string name) { }
    public FaultCode(string name, System.ServiceModel.FaultCode subcode) { }
    public FaultCode(string name, string ns) { }
    public FaultCode(string name, string ns, System.ServiceModel.FaultCode subcode) { }
    public bool IsPredefinedFault { get { return default(bool); } }
    public bool IsReceiverFault { get { return default(bool); } }
    public bool IsSenderFault { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public System.ServiceModel.FaultCode SubCode { get { return default(System.ServiceModel.FaultCode); } }
    public static System.ServiceModel.FaultCode CreateReceiverFaultCode(System.ServiceModel.FaultCode subcode) { return default(System.ServiceModel.FaultCode); }
    public static System.ServiceModel.FaultCode CreateReceiverFaultCode(string name, string ns) { return default(System.ServiceModel.FaultCode); }
    public static System.ServiceModel.FaultCode CreateSenderFaultCode(System.ServiceModel.FaultCode subcode) { return default(System.ServiceModel.FaultCode); }
    public static System.ServiceModel.FaultCode CreateSenderFaultCode(string name, string ns) { return default(System.ServiceModel.FaultCode); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64), Inherited=false, AllowMultiple=true)]
  public sealed partial class FaultContractAttribute : System.Attribute {
    public FaultContractAttribute(System.Type detailType) { }
    public string Action { get { return default(string); } set { } }
    public System.Type DetailType { get { return default(System.Type); } }
    public bool HasProtectionLevel { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
  }
  public partial class FaultException : System.ServiceModel.CommunicationException {
    public FaultException() { }
    [System.MonoTODOAttribute]
    protected FaultException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    [System.MonoTODOAttribute]
    public FaultException(System.ServiceModel.Channels.MessageFault fault) { }
    public FaultException(System.ServiceModel.Channels.MessageFault fault, string action) { }
    [System.MonoTODOAttribute]
    public FaultException(System.ServiceModel.FaultReason reason) { }
    public FaultException(System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code) { }
    public FaultException(System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code, string action) { }
    public FaultException(string msg) { }
    public FaultException(string msg, System.ServiceModel.FaultCode code) { }
    public FaultException(string reason, System.ServiceModel.FaultCode code, string action) { }
    public string Action { get { return default(string); } }
    public System.ServiceModel.FaultCode Code { get { return default(System.ServiceModel.FaultCode); } }
    public override string Message { get { return default(string); } }
    public System.ServiceModel.FaultReason Reason { get { return default(System.ServiceModel.FaultReason); } }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.FaultException CreateFault(System.ServiceModel.Channels.MessageFault messageFault, string action, params System.Type[] faultDetailTypes) { return default(System.ServiceModel.FaultException); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.FaultException CreateFault(System.ServiceModel.Channels.MessageFault fault, params System.Type[] details) { return default(System.ServiceModel.FaultException); }
    public virtual System.ServiceModel.Channels.MessageFault CreateMessageFault() { return default(System.ServiceModel.Channels.MessageFault); }
    [System.MonoTODOAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class FaultException<TDetail> : System.ServiceModel.FaultException {
    public FaultException(TDetail detail) { }
    public FaultException(TDetail detail, System.ServiceModel.FaultReason reason) { }
    public FaultException(TDetail detail, System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code) { }
    public FaultException(TDetail detail, System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code, string action) { }
    public FaultException(TDetail detail, string reason) { }
    public FaultException(TDetail detail, string reason, System.ServiceModel.FaultCode code) { }
    public FaultException(TDetail detail, string reason, System.ServiceModel.FaultCode code, string action) { }
    [System.MonoTODOAttribute]
    protected FaultException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public TDetail Detail { get { return default(TDetail); } }
    public override System.ServiceModel.Channels.MessageFault CreateMessageFault() { return default(System.ServiceModel.Channels.MessageFault); }
    [System.MonoTODOAttribute("see FaultException.TestGetObjectData to see how it's serialized")]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public override string ToString() { return default(string); }
  }
  public partial class FaultReason {
    public FaultReason(System.Collections.Generic.IEnumerable<System.ServiceModel.FaultReasonText> translations) { }
    public FaultReason(System.ServiceModel.FaultReasonText translation) { }
    public FaultReason(string text) { }
    public System.Collections.Generic.SynchronizedReadOnlyCollection<System.ServiceModel.FaultReasonText> Translations { get { return default(System.Collections.Generic.SynchronizedReadOnlyCollection<System.ServiceModel.FaultReasonText>); } }
    public System.ServiceModel.FaultReasonText GetMatchingTranslation() { return default(System.ServiceModel.FaultReasonText); }
    public System.ServiceModel.FaultReasonText GetMatchingTranslation(System.Globalization.CultureInfo cultureInfo) { return default(System.ServiceModel.FaultReasonText); }
    public override string ToString() { return default(string); }
  }
  public partial class FaultReasonText {
    public FaultReasonText(string text) { }
    public FaultReasonText(string text, System.Globalization.CultureInfo cultureInfo) { }
    public FaultReasonText(string text, string xmlLang) { }
    public string Text { get { return default(string); } }
    public string XmlLang { get { return default(string); } }
    public bool Matches(System.Globalization.CultureInfo cultureInfo) { return default(bool); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class FederatedMessageSecurityOverHttp {
    internal FederatedMessageSecurityOverHttp() { }
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.ClaimTypeRequirement> ClaimTypeRequirements { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.ClaimTypeRequirement>); } }
    public bool EstablishSecurityContext { get { return default(bool); } set { } }
    public System.IdentityModel.Tokens.SecurityKeyType IssuedKeyType { get { return default(System.IdentityModel.Tokens.SecurityKeyType); } set { } }
    public string IssuedTokenType { get { return default(string); } set { } }
    public System.ServiceModel.EndpointAddress IssuerAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.Binding IssuerBinding { get { return default(System.ServiceModel.Channels.Binding); } set { } }
    public System.ServiceModel.EndpointAddress IssuerMetadataAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public bool NegotiateServiceCredential { get { return default(bool); } set { } }
    public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> TokenRequestParameters { get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlElement>); } }
  }
  public enum HostNameComparisonMode {
    Exact = 1,
    StrongWildcard = 0,
    WeakWildcard = 2,
  }
  public enum HttpClientCredentialType {
    Basic = 1,
    Certificate = 5,
    Digest = 2,
    None = 0,
    Ntlm = 3,
    Windows = 4,
  }
  public enum HttpProxyCredentialType {
    Basic = 1,
    Digest = 2,
    None = 0,
    Ntlm = 3,
    Windows = 4,
  }
  public sealed partial class HttpTransportSecurity {
    internal HttpTransportSecurity() { }
    public System.ServiceModel.HttpClientCredentialType ClientCredentialType { get { return default(System.ServiceModel.HttpClientCredentialType); } set { } }
    public System.ServiceModel.HttpProxyCredentialType ProxyCredentialType { get { return default(System.ServiceModel.HttpProxyCredentialType); } set { } }
    public string Realm { get { return default(string); } set { } }
  }
  public partial interface IClientChannel : System.IDisposable, System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> {
    bool AllowInitializationUI { get; set; }
    bool DidInteractiveInitialization { get; }
    System.Uri Via { get; }
    event System.EventHandler<System.ServiceModel.UnknownMessageReceivedEventArgs> UnknownMessageReceived;
    System.IAsyncResult BeginDisplayInitializationUI(System.AsyncCallback callback, object state);
    void DisplayInitializationUI();
    void EndDisplayInitializationUI(System.IAsyncResult result);
  }
  public partial interface ICommunicationObject {
    System.ServiceModel.CommunicationState State { get; }
    event System.EventHandler Closed;
    event System.EventHandler Closing;
    event System.EventHandler Faulted;
    event System.EventHandler Opened;
    event System.EventHandler Opening;
    void Abort();
    System.IAsyncResult BeginClose(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginOpen(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void Close();
    void Close(System.TimeSpan timeout);
    void EndClose(System.IAsyncResult result);
    void EndOpen(System.IAsyncResult result);
    void Open();
    void Open(System.TimeSpan timeout);
  }
  public partial interface IContextChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> {
    bool AllowOutputBatching { get; set; }
    System.ServiceModel.Channels.IInputSession InputSession { get; }
    System.ServiceModel.EndpointAddress LocalAddress { get; }
    System.TimeSpan OperationTimeout { get; set; }
    System.ServiceModel.Channels.IOutputSession OutputSession { get; }
    System.ServiceModel.EndpointAddress RemoteAddress { get; }
    string SessionId { get; }
  }
  public partial interface IDefaultCommunicationTimeouts {
    System.TimeSpan CloseTimeout { get; }
    System.TimeSpan OpenTimeout { get; }
    System.TimeSpan ReceiveTimeout { get; }
    System.TimeSpan SendTimeout { get; }
  }
  public partial interface IDuplexContextChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> {
    bool AutomaticInputSessionShutdown { get; set; }
    System.ServiceModel.InstanceContext CallbackInstance { get; set; }
    System.IAsyncResult BeginCloseOutputSession(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void CloseOutputSession(System.TimeSpan timeout);
    void EndCloseOutputSession(System.IAsyncResult result);
  }
  public partial interface IExtensibleObject<T> where T : System.ServiceModel.IExtensibleObject<T> {
    System.ServiceModel.IExtensionCollection<T> Extensions { get; }
  }
  public partial interface IExtension<T> where T : System.ServiceModel.IExtensibleObject<T> {
    void Attach(T owner);
    void Detach(T owner);
  }
  public partial interface IExtensionCollection<T> : System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>, System.Collections.Generic.IEnumerable<System.ServiceModel.IExtension<T>>, System.Collections.IEnumerable where T : System.ServiceModel.IExtensibleObject<T> {
    E Find<E>();
    System.Collections.ObjectModel.Collection<E> FindAll<E>();
  }
  public enum ImpersonationOption {
    Allowed = 1,
    NotAllowed = 0,
    Required = 2,
  }
  public sealed partial class InstanceContext : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.IExtensibleObject<System.ServiceModel.InstanceContext> {
    public InstanceContext(object implementation) { }
    public InstanceContext(System.ServiceModel.ServiceHostBase host) { }
    public InstanceContext(System.ServiceModel.ServiceHostBase host, object implementation) { }
    protected internal override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.ServiceModel.IExtensionCollection<System.ServiceModel.InstanceContext> Extensions { get { return default(System.ServiceModel.IExtensionCollection<System.ServiceModel.InstanceContext>); } }
    public System.ServiceModel.ServiceHostBase Host { get { return default(System.ServiceModel.ServiceHostBase); } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Channels.IChannel> IncomingChannels { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Channels.IChannel>); } }
    public int ManualFlowControlLimit { get { return default(int); } set { } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Channels.IChannel> OutgoingChannels { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Channels.IChannel>); } }
    public object GetServiceInstance() { return default(object); }
    public object GetServiceInstance(System.ServiceModel.Channels.Message message) { return default(object); }
    public int IncrementManualFlowControlLimit(int incrementBy) { return default(int); }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnClosed() { }
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected override void OnEndOpen(System.IAsyncResult result) { }
    protected override void OnFaulted() { }
    protected override void OnOpen(System.TimeSpan timeout) { }
    [System.MonoTODOAttribute]
    protected override void OnOpened() { }
    protected override void OnOpening() { }
    public void ReleaseServiceInstance() { }
  }
  public enum InstanceContextMode {
    PerCall = 1,
    PerSession = 0,
    Single = 2,
  }
  public partial class InvalidMessageContractException : System.SystemException {
    public InvalidMessageContractException() { }
    protected InvalidMessageContractException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidMessageContractException(string msg) { }
    public InvalidMessageContractException(string msg, System.Exception inner) { }
  }
  public partial interface IOnlineStatus {
    bool IsOnline { get; }
    event System.EventHandler Offline;
    event System.EventHandler Online;
  }
  public partial interface IServiceChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> {
    System.Uri ListenUri { get; }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false)]
  public partial class MessageBodyMemberAttribute : System.ServiceModel.MessageContractMemberAttribute {
    public MessageBodyMemberAttribute() { }
    public int Order { get { return default(int); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(12))]
  public sealed partial class MessageContractAttribute : System.Attribute {
    public MessageContractAttribute() { }
    public bool HasProtectionLevel { get { return default(bool); } }
    public bool IsWrapped { get { return default(bool); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public string WrapperName { get { return default(string); } set { } }
    public string WrapperNamespace { get { return default(string); } set { } }
  }
  public abstract partial class MessageContractMemberAttribute : System.Attribute {
    protected MessageContractMemberAttribute() { }
    public bool HasProtectionLevel { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
  }
  public enum MessageCredentialType {
    Certificate = 3,
    IssuedToken = 4,
    None = 0,
    UserName = 2,
    Windows = 1,
  }
  public partial class MessageHeader<T> {
    public MessageHeader() { }
    public MessageHeader(T content) { }
    public MessageHeader(T content, bool must_understand, string actor, bool relay) { }
    public string Actor { get { return default(string); } set { } }
    public T Content { get { return default(T); } set { } }
    public bool MustUnderstand { get { return default(bool); } set { } }
    public bool Relay { get { return default(bool); } set { } }
    public System.ServiceModel.Channels.MessageHeader GetUntypedHeader(string name, string ns) { return default(System.ServiceModel.Channels.MessageHeader); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false)]
  public sealed partial class MessageHeaderArrayAttribute : System.ServiceModel.MessageHeaderAttribute {
    public MessageHeaderArrayAttribute() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false)]
  public partial class MessageHeaderAttribute : System.ServiceModel.MessageContractMemberAttribute {
    public MessageHeaderAttribute() { }
    public string Actor { get { return default(string); } set { } }
    public bool MustUnderstand { get { return default(bool); } set { } }
    public bool Relay { get { return default(bool); } set { } }
  }
  public partial class MessageHeaderException : System.ServiceModel.ProtocolException {
    public MessageHeaderException() { }
    protected MessageHeaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MessageHeaderException(string msg) { }
    public MessageHeaderException(string message, bool isDuplicate) { }
    public MessageHeaderException(string msg, System.Exception inner) { }
    public MessageHeaderException(string message, string headerName, string ns) { }
    public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate) { }
    public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate, System.Exception innerException) { }
    public MessageHeaderException(string message, string headerName, string ns, System.Exception innerException) { }
    public string HeaderName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string HeaderNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public bool IsDuplicate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(10240), Inherited=false)]
  public sealed partial class MessageParameterAttribute : System.Attribute {
    public MessageParameterAttribute() { }
    public string Name { get { return default(string); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false)]
  public sealed partial class MessagePropertyAttribute : System.Attribute {
    public MessagePropertyAttribute() { }
    public string Name { get { return default(string); } set { } }
  }
  public partial class MessageSecurityOverHttp {
    internal MessageSecurityOverHttp() { }
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public System.ServiceModel.MessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.MessageCredentialType); } set { } }
    public bool NegotiateServiceCredential { get { return default(bool); } set { } }
    protected virtual bool IsSecureConversationEnabled() { return default(bool); }
  }
  public sealed partial class MessageSecurityOverMsmq {
    internal MessageSecurityOverMsmq() { }
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public System.ServiceModel.MessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.MessageCredentialType); } set { } }
  }
  public sealed partial class MessageSecurityOverTcp {
    internal MessageSecurityOverTcp() { }
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public System.ServiceModel.MessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.MessageCredentialType); } set { } }
  }
  public abstract partial class MessageSecurityVersion {
    internal MessageSecurityVersion() { }
    public abstract System.ServiceModel.Security.BasicSecurityProfileVersion BasicSecurityProfileVersion { get; }
    public static System.ServiceModel.MessageSecurityVersion Default { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public System.ServiceModel.Security.SecureConversationVersion SecureConversationVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.SecureConversationVersion); } }
    public abstract System.ServiceModel.Security.SecurityPolicyVersion SecurityPolicyVersion { get; }
    public abstract System.IdentityModel.Selectors.SecurityTokenVersion SecurityTokenVersion { get; }
    public abstract System.ServiceModel.Security.SecurityVersion SecurityVersion { get; }
    public System.ServiceModel.Security.TrustVersion TrustVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.TrustVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity10WSTrust13WSSecureConversation13WSSecurityPolicy12BasicSecurityProfile10 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity10WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12BasicSecurityProfile10 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
    public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get { return default(System.ServiceModel.MessageSecurityVersion); } }
  }
  public enum MsmqAuthenticationMode {
    Certificate = 2,
    None = 0,
    WindowsDomain = 1,
  }
  public abstract partial class MsmqBindingBase : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    protected MsmqBindingBase() { }
    public System.Uri CustomDeadLetterQueue { get { return default(System.Uri); } set { } }
    public System.ServiceModel.DeadLetterQueue DeadLetterQueue { get { return default(System.ServiceModel.DeadLetterQueue); } set { } }
    public bool Durable { get { return default(bool); } set { } }
    public bool ExactlyOnce { get { return default(bool); } set { } }
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public int MaxRetryCycles { get { return default(int); } set { } }
    public System.ServiceModel.ReceiveErrorHandling ReceiveErrorHandling { get { return default(System.ServiceModel.ReceiveErrorHandling); } set { } }
    public int ReceiveRetryCount { get { return default(int); } set { } }
    public System.TimeSpan RetryCycleDelay { get { return default(System.TimeSpan); } set { } }
    public override string Scheme { get { return default(string); } }
    [System.MonoTODOAttribute]
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    public System.TimeSpan TimeToLive { get { return default(System.TimeSpan); } set { } }
    public bool UseMsmqTracing { get { return default(bool); } set { } }
    public bool UseSourceJournal { get { return default(bool); } set { } }
  }
  public enum MsmqEncryptionAlgorithm {
    Aes = 1,
    RC4Stream = 0,
  }
  public partial class MsmqException : System.Runtime.InteropServices.ExternalException {
    public MsmqException() { }
    protected MsmqException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MsmqException(string msg) { }
    public MsmqException(string msg, System.Exception inner) { }
    public MsmqException(string msg, int win32ErrorCode) { }
  }
  public partial class MsmqPoisonMessageException : System.ServiceModel.PoisonMessageException {
    public MsmqPoisonMessageException() { }
    protected MsmqPoisonMessageException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MsmqPoisonMessageException(string msg) { }
    public MsmqPoisonMessageException(string msg, System.Exception inner) { }
  }
  public enum MsmqSecureHashAlgorithm {
    MD5 = 0,
    Sha1 = 1,
    Sha256 = 2,
    Sha512 = 3,
  }
  public sealed partial class MsmqTransportSecurity {
    public MsmqTransportSecurity() { }
    public MsmqTransportSecurity(System.ServiceModel.MsmqTransportSecurity other) { }
    public System.ServiceModel.MsmqAuthenticationMode MsmqAuthenticationMode { get { return default(System.ServiceModel.MsmqAuthenticationMode); } set { } }
    public System.ServiceModel.MsmqEncryptionAlgorithm MsmqEncryptionAlgorithm { get { return default(System.ServiceModel.MsmqEncryptionAlgorithm); } set { } }
    public System.Net.Security.ProtectionLevel MsmqProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public System.ServiceModel.MsmqSecureHashAlgorithm MsmqSecureHashAlgorithm { get { return default(System.ServiceModel.MsmqSecureHashAlgorithm); } set { } }
  }
  public sealed partial class NamedPipeTransportSecurity {
    internal NamedPipeTransportSecurity() { }
    public System.Net.Security.ProtectionLevel ProtectionLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Security.ProtectionLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class NetMsmqBinding : System.ServiceModel.MsmqBindingBase {
    public NetMsmqBinding() { }
    public NetMsmqBinding(System.ServiceModel.NetMsmqSecurityMode securityMode) { }
    [System.MonoTODOAttribute]
    public NetMsmqBinding(string configurationName) { }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    public System.ServiceModel.QueueTransferProtocol QueueTransferProtocol { get { return default(System.ServiceModel.QueueTransferProtocol); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.ServiceModel.NetMsmqSecurity Security { get { return default(System.ServiceModel.NetMsmqSecurity); } }
    public bool UseActiveDirectory { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public sealed partial class NetMsmqSecurity {
    internal NetMsmqSecurity() { }
    public System.ServiceModel.MessageSecurityOverMsmq Message { get { return default(System.ServiceModel.MessageSecurityOverMsmq); } }
    public System.ServiceModel.NetMsmqSecurityMode Mode { get { return default(System.ServiceModel.NetMsmqSecurityMode); } set { } }
    public System.ServiceModel.MsmqTransportSecurity Transport { get { return default(System.ServiceModel.MsmqTransportSecurity); } }
  }
  public enum NetMsmqSecurityMode {
    Both = 3,
    Message = 2,
    None = 0,
    Transport = 1,
  }
  public partial class NetNamedPipeBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public NetNamedPipeBinding() { }
    public NetNamedPipeBinding(System.ServiceModel.NetNamedPipeSecurityMode securityMode) { }
    [System.MonoTODOAttribute]
    public NetNamedPipeBinding(string configurationName) { }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public static bool IsPnrpAvailable { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.MonoTODOAttribute]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public int MaxConnections { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.NetNamedPipeSecurity Security { get { return default(System.ServiceModel.NetNamedPipeSecurity); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public bool TransactionFlow { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.TransactionProtocol TransactionProtocol { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.TransactionProtocol); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public sealed partial class NetNamedPipeSecurity {
    internal NetNamedPipeSecurity() { }
    public System.ServiceModel.NetNamedPipeSecurityMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.NetNamedPipeSecurityMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.NamedPipeTransportSecurity Transport { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.NamedPipeTransportSecurity); } }
  }
  public enum NetNamedPipeSecurityMode {
    None = 0,
    Transport = 1,
  }
  public partial class NetPeerTcpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public NetPeerTcpBinding() { }
    [System.MonoTODOAttribute]
    public NetPeerTcpBinding(string configurationName) { }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static bool IsPnrpAvailable { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public System.Net.IPAddress ListenIPAddress { get { return default(System.Net.IPAddress); } set { } }
    [System.MonoTODOAttribute]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.MonoTODOAttribute]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public int Port { get { return default(int); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.ServiceModel.PeerResolvers.PeerResolverSettings Resolver { get { return default(System.ServiceModel.PeerResolvers.PeerResolverSettings); } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.PeerSecuritySettings Security { get { return default(System.ServiceModel.PeerSecuritySettings); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public partial class NetTcpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public NetTcpBinding() { }
    public NetTcpBinding(System.ServiceModel.SecurityMode securityMode) { }
    public NetTcpBinding(System.ServiceModel.SecurityMode securityMode, bool reliableSessionEnabled) { }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public int ListenBacklog { get { return default(int); } set { } }
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public int MaxConnections { get { return default(int); } set { } }
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public bool PortSharingEnabled { get { return default(bool); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.OptionalReliableSession ReliableSession { get { return default(System.ServiceModel.OptionalReliableSession); } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.NetTcpSecurity Security { get { return default(System.ServiceModel.NetTcpSecurity); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    public bool TransactionFlow { get { return default(bool); } set { } }
    public System.ServiceModel.TransactionProtocol TransactionProtocol { get { return default(System.ServiceModel.TransactionProtocol); } set { } }
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public sealed partial class NetTcpSecurity {
    internal NetTcpSecurity() { }
    public System.ServiceModel.MessageSecurityOverTcp Message { get { return default(System.ServiceModel.MessageSecurityOverTcp); } }
    public System.ServiceModel.SecurityMode Mode { get { return default(System.ServiceModel.SecurityMode); } set { } }
    public System.ServiceModel.TcpTransportSecurity Transport { get { return default(System.ServiceModel.TcpTransportSecurity); } }
  }
  public sealed partial class NonDualMessageSecurityOverHttp : System.ServiceModel.MessageSecurityOverHttp {
    internal NonDualMessageSecurityOverHttp() { }
    [System.MonoTODOAttribute]
    public bool EstablishSecurityContext { get { return default(bool); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class OperationBehaviorAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior {
    public OperationBehaviorAttribute() { }
    public bool AutoDisposeParameters { get { return default(bool); } set { } }
    public System.ServiceModel.ImpersonationOption Impersonation { get { return default(System.ServiceModel.ImpersonationOption); } set { } }
    public System.ServiceModel.ReleaseInstanceMode ReleaseInstanceMode { get { return default(System.ServiceModel.ReleaseInstanceMode); } set { } }
    public bool TransactionAutoComplete { get { return default(bool); } set { } }
    public bool TransactionScopeRequired { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription description) { }
  }
  public sealed partial class OperationContext : System.ServiceModel.IExtensibleObject<System.ServiceModel.OperationContext> {
    public OperationContext(System.ServiceModel.IContextChannel channel) { }
    public System.ServiceModel.IContextChannel Channel { get { return default(System.ServiceModel.IContextChannel); } }
    public static System.ServiceModel.OperationContext Current { get { return default(System.ServiceModel.OperationContext); } set { } }
    public System.ServiceModel.Dispatcher.EndpointDispatcher EndpointDispatcher { get { return default(System.ServiceModel.Dispatcher.EndpointDispatcher); } set { } }
    public System.ServiceModel.IExtensionCollection<System.ServiceModel.OperationContext> Extensions { get { return default(System.ServiceModel.IExtensionCollection<System.ServiceModel.OperationContext>); } }
    public bool HasSupportingTokens { get { return default(bool); } }
    public System.ServiceModel.ServiceHostBase Host { get { return default(System.ServiceModel.ServiceHostBase); } }
    public System.ServiceModel.Channels.MessageHeaders IncomingMessageHeaders { get { return default(System.ServiceModel.Channels.MessageHeaders); } }
    public System.ServiceModel.Channels.MessageProperties IncomingMessageProperties { get { return default(System.ServiceModel.Channels.MessageProperties); } }
    public System.ServiceModel.Channels.MessageVersion IncomingMessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.InstanceContext InstanceContext { get { return default(System.ServiceModel.InstanceContext); } }
    public bool IsUserContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public System.ServiceModel.Channels.MessageHeaders OutgoingMessageHeaders { get { return default(System.ServiceModel.Channels.MessageHeaders); } }
    public System.ServiceModel.Channels.MessageProperties OutgoingMessageProperties { get { return default(System.ServiceModel.Channels.MessageProperties); } }
    public System.ServiceModel.Channels.RequestContext RequestContext { get { return default(System.ServiceModel.Channels.RequestContext); } set { } }
    public System.ServiceModel.ServiceSecurityContext ServiceSecurityContext { get { return default(System.ServiceModel.ServiceSecurityContext); } }
    public string SessionId { get { return default(string); } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Security.SupportingTokenSpecification> SupportingTokens { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Security.SupportingTokenSpecification>); } }
    public event System.EventHandler OperationCompleted { add { } remove { } }
    public T GetCallbackChannel<T>() { return default(T); }
    [System.MonoTODOAttribute]
    public void SetTransactionComplete() { }
  }
  public sealed partial class OperationContextScope : System.IDisposable {
    public OperationContextScope(System.ServiceModel.IContextChannel channel) { }
    public OperationContextScope(System.ServiceModel.OperationContext context) { }
    public void Dispose() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class OperationContractAttribute : System.Attribute {
    public OperationContractAttribute() { }
    public string Action { get { return default(string); } set { } }
    public bool AsyncPattern { get { return default(bool); } set { } }
    public bool HasProtectionLevel { get { return default(bool); } }
    public bool IsInitiating { get { return default(bool); } set { } }
    public bool IsOneWay { get { return default(bool); } set { } }
    public bool IsTerminating { get { return default(bool); } set { } }
    public string Name { get { return default(string); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public string ReplyAction { get { return default(string); } set { } }
  }
  public enum OperationFormatStyle {
    Document = 0,
    Rpc = 1,
  }
  public enum OperationFormatUse {
    Encoded = 1,
    Literal = 0,
  }
  public partial class OptionalReliableSession : System.ServiceModel.ReliableSession {
    public OptionalReliableSession() { }
    public OptionalReliableSession(System.ServiceModel.Channels.ReliableSessionBindingElement binding) { }
    public bool Enabled { get { return default(bool); } set { } }
  }
  public partial class PeerHopCountAttribute {
    public PeerHopCountAttribute() { }
  }
  public enum PeerMessageOrigination {
    Local = 0,
    Remote = 1,
  }
  public enum PeerMessagePropagation {
    Local = 1,
    LocalAndRemote = 3,
    None = 0,
    Remote = 2,
  }
  public abstract partial class PeerMessagePropagationFilter {
    protected PeerMessagePropagationFilter() { }
    public abstract System.ServiceModel.PeerMessagePropagation ShouldMessagePropagate(System.ServiceModel.Channels.Message message, System.ServiceModel.PeerMessageOrigination origination);
  }
  public abstract partial class PeerNode : System.ServiceModel.IOnlineStatus {
    internal PeerNode() { }
    public bool IsOnline { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public abstract System.ServiceModel.PeerMessagePropagationFilter MessagePropagationFilter { get; set; }
    public int Port { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
    public event System.EventHandler Offline { add { } remove { } }
    public event System.EventHandler Online { add { } remove { } }
    public void RefreshConnection() { }
    public override string ToString() { return default(string); }
  }
  [System.Runtime.Serialization.DataContractAttribute(Name="PeerNodeAddress", Namespace="http://schemas.microsoft.com/net/2006/05/peer")]
  [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Net.IPAddress[]))]
  public sealed partial class PeerNodeAddress {
    public PeerNodeAddress(System.ServiceModel.EndpointAddress endpointAddress, System.Collections.ObjectModel.ReadOnlyCollection<System.Net.IPAddress> ipAddresses) { }
    public System.ServiceModel.EndpointAddress EndpointAddress { get { return default(System.ServiceModel.EndpointAddress); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Net.IPAddress> IPAddresses { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Net.IPAddress>); } }
  }
  public abstract partial class PeerResolver {
    protected PeerResolver() { }
    public abstract bool CanShareReferrals { get; }
    public virtual void Initialize(System.ServiceModel.EndpointAddress address, System.ServiceModel.Channels.Binding binding, System.ServiceModel.Description.ClientCredentials credentials, System.ServiceModel.PeerResolvers.PeerReferralPolicy referralPolicy) { }
    public abstract object Register(string meshId, System.ServiceModel.PeerNodeAddress nodeAddress, System.TimeSpan timeout);
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.PeerNodeAddress> Resolve(string meshId, int maxAddresses, System.TimeSpan timeout);
    public abstract void Unregister(object registrationId, System.TimeSpan timeout);
    public abstract void Update(object registrationId, System.ServiceModel.PeerNodeAddress updatedNodeAddress, System.TimeSpan timeout);
  }
  public partial class PeerSecuritySettings {
    public PeerSecuritySettings() { }
    public System.ServiceModel.SecurityMode Mode { get { return default(System.ServiceModel.SecurityMode); } set { } }
    public System.ServiceModel.PeerTransportSecuritySettings Transport { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.PeerTransportSecuritySettings); } }
  }
  public enum PeerTransportCredentialType {
    Certificate = 1,
    Password = 0,
  }
  public sealed partial class PeerTransportSecuritySettings {
    internal PeerTransportSecuritySettings() { }
    public System.ServiceModel.PeerTransportCredentialType CredentialType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.PeerTransportCredentialType); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class PoisonMessageException : System.SystemException {
    public PoisonMessageException() { }
    protected PoisonMessageException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public PoisonMessageException(string msg) { }
    public PoisonMessageException(string msg, System.Exception inner) { }
  }
  public partial class ProtocolException : System.ServiceModel.CommunicationException {
    public ProtocolException() { }
    protected ProtocolException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ProtocolException(string msg) { }
    public ProtocolException(string msg, System.Exception inner) { }
  }
  public enum QueuedDeliveryRequirementsMode {
    Allowed = 0,
    NotAllowed = 2,
    Required = 1,
  }
  public enum QueueTransferProtocol {
    Native = 0,
    Srmp = 1,
    SrmpSecure = 2,
  }
  public partial class QuotaExceededException : System.SystemException {
    public QuotaExceededException() { }
    protected QuotaExceededException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public QuotaExceededException(string msg) { }
    public QuotaExceededException(string msg, System.Exception inner) { }
  }
  public enum ReceiveErrorHandling {
    Drop = 1,
    Fault = 0,
    Move = 3,
    Reject = 2,
  }
  public enum ReleaseInstanceMode {
    AfterCall = 2,
    BeforeAndAfterCall = 3,
    BeforeCall = 1,
    None = 0,
  }
  [System.MonoTODOAttribute]
  public abstract partial class ReliableMessagingVersion {
    protected ReliableMessagingVersion() { }
    public static System.ServiceModel.ReliableMessagingVersion Default { get { return default(System.ServiceModel.ReliableMessagingVersion); } }
    public static System.ServiceModel.ReliableMessagingVersion WSReliableMessaging11 { get { return default(System.ServiceModel.ReliableMessagingVersion); } }
    public static System.ServiceModel.ReliableMessagingVersion WSReliableMessagingFebruary2005 { get { return default(System.ServiceModel.ReliableMessagingVersion); } }
  }
  public partial class ReliableSession {
    public ReliableSession() { }
    public ReliableSession(System.ServiceModel.Channels.ReliableSessionBindingElement binding) { }
    public System.TimeSpan InactivityTimeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool Ordered { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class RsaEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public RsaEndpointIdentity(System.IdentityModel.Claims.Claim identity) { }
    public RsaEndpointIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 cert) { }
    [System.MonoTODOAttribute]
    public RsaEndpointIdentity(string publicKey) { }
  }
  public enum SecurityMode {
    Message = 2,
    None = 0,
    Transport = 1,
    TransportWithMessageCredential = 3,
  }
  public partial class ServerTooBusyException : System.ServiceModel.CommunicationException {
    public ServerTooBusyException() { }
    protected ServerTooBusyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ServerTooBusyException(string msg) { }
    public ServerTooBusyException(string msg, System.Exception inner) { }
  }
  public partial class ServiceActivationException : System.ServiceModel.CommunicationException {
    public ServiceActivationException() { }
    protected ServiceActivationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ServiceActivationException(string msg) { }
    public ServiceActivationException(string msg, System.Exception inner) { }
  }
  public partial class ServiceAuthorizationManager {
    public ServiceAuthorizationManager() { }
    public virtual bool CheckAccess(System.ServiceModel.OperationContext context) { return default(bool); }
    public virtual bool CheckAccess(System.ServiceModel.OperationContext context, ref System.ServiceModel.Channels.Message message) { return default(bool); }
    [System.MonoTODOAttribute]
    protected virtual bool CheckAccessCore(System.ServiceModel.OperationContext context) { return default(bool); }
    [System.MonoTODOAttribute]
    protected virtual System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> GetAuthorizationPolicies(System.ServiceModel.OperationContext context) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  public sealed partial class ServiceBehaviorAttribute : System.Attribute, System.ServiceModel.Description.IServiceBehavior {
    public ServiceBehaviorAttribute() { }
    [System.MonoTODOAttribute]
    public System.ServiceModel.AddressFilterMode AddressFilterMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.AddressFilterMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool AutomaticSessionShutdown { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.ConcurrencyMode ConcurrencyMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.ConcurrencyMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public string ConfigurationName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool IgnoreExtensionDataObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IncludeExceptionDetailInFaults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.InstanceContextMode InstanceContextMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.InstanceContextMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int MaxItemsInObjectGraph { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool ReleaseServiceInstanceOnTransactionComplete { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool TransactionAutoCompleteOnSessionClose { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Transactions.IsolationLevel TransactionIsolationLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Transactions.IsolationLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public string TransactionTimeout { get { return default(string); } set { } }
    public bool UseSynchronizationContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool ValidateMustUnderstand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object GetWellKnownSingleton() { return default(object); }
    public void SetWellKnownSingleton(object value) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028), Inherited=false)]
  public sealed partial class ServiceContractAttribute : System.Attribute {
    public ServiceContractAttribute() { }
    public System.Type CallbackContract { get { return default(System.Type); } set { } }
    public string ConfigurationName { get { return default(string); } set { } }
    public bool HasProtectionLevel { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public System.ServiceModel.SessionMode SessionMode { get { return default(System.ServiceModel.SessionMode); } set { } }
  }
  public partial class ServiceHost : System.ServiceModel.ServiceHostBase {
    protected ServiceHost() { }
    public ServiceHost(object serviceInstance, params System.Uri[] baseAddresses) { }
    public ServiceHost(System.Type serviceType, params System.Uri[] baseAddresses) { }
    public object SingletonInstance { get { return default(object); } }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, string address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, string address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(System.Type implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected override System.ServiceModel.Description.ServiceDescription CreateDescription(out System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription> implementedContracts) { implementedContracts = default(System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription>); return default(System.ServiceModel.Description.ServiceDescription); }
    protected void InitializeDescription(object serviceInstance, System.ServiceModel.UriSchemeKeyedCollection baseAddresses) { }
    protected void InitializeDescription(System.Type serviceType, System.ServiceModel.UriSchemeKeyedCollection baseAddresses) { }
  }
  public abstract partial class ServiceHostBase : System.ServiceModel.Channels.CommunicationObject, System.IDisposable, System.ServiceModel.IExtensibleObject<System.ServiceModel.ServiceHostBase> {
    protected ServiceHostBase() { }
    public System.ServiceModel.Description.ServiceAuthorizationBehavior Authorization { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Description.ServiceAuthorizationBehavior); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Uri> BaseAddresses { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Uri>); } }
    public System.ServiceModel.Dispatcher.ChannelDispatcherCollection ChannelDispatchers { get { return default(System.ServiceModel.Dispatcher.ChannelDispatcherCollection); } }
    public System.TimeSpan CloseTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Description.ServiceCredentials Credentials { get { return default(System.ServiceModel.Description.ServiceCredentials); } }
    protected internal override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.ServiceModel.Description.ServiceDescription Description { get { return default(System.ServiceModel.Description.ServiceDescription); } }
    public System.ServiceModel.IExtensionCollection<System.ServiceModel.ServiceHostBase> Extensions { get { return default(System.ServiceModel.IExtensionCollection<System.ServiceModel.ServiceHostBase>); } }
    protected internal System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription> ImplementedContracts { get { return default(System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription>); } }
    public int ManualFlowControlLimit { get { return default(int); } set { } }
    public System.TimeSpan OpenTimeout { get { return default(System.TimeSpan); } set { } }
    public event System.EventHandler<System.ServiceModel.UnknownMessageReceivedEventArgs> UnknownMessageReceived { add { } remove { } }
    protected void AddBaseAddress(System.Uri baseAddress) { }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, string address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, string address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint AddServiceEndpoint(string implementedContract, System.ServiceModel.Channels.Binding binding, System.Uri address, System.Uri listenUri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    protected virtual void ApplyConfiguration() { }
    protected abstract System.ServiceModel.Description.ServiceDescription CreateDescription(out System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Description.ContractDescription> implementedContracts);
    protected void InitializeDescription(System.ServiceModel.UriSchemeKeyedCollection baseAddresses) { }
    protected virtual void InitializeRuntime() { }
    protected void LoadConfigurationSection(System.ServiceModel.Configuration.ServiceElement element) { }
    protected sealed override void OnAbort() { }
    protected sealed override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected sealed override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected sealed override void OnEndOpen(System.IAsyncResult result) { }
    protected sealed override void OnOpen(System.TimeSpan timeout) { }
    protected override void OnOpened() { }
    [System.MonoTODOAttribute]
    protected void ReleasePerformanceCounters() { }
    void System.IDisposable.Dispose() { }
  }
  public static partial class ServiceHostingEnvironment {
    public static bool AspNetCompatibilityEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } }
    public static void EnsureServiceAvailable(string virtualPath) { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1092), AllowMultiple=true, Inherited=true)]
  public sealed partial class ServiceKnownTypeAttribute : System.Attribute {
    public ServiceKnownTypeAttribute(string methodName) { }
    public ServiceKnownTypeAttribute(string methodName, System.Type declaringType) { }
    public ServiceKnownTypeAttribute(System.Type type) { }
    public System.Type DeclaringType { get { return default(System.Type); } }
    public string MethodName { get { return default(string); } }
    public System.Type Type { get { return default(System.Type); } }
  }
  public partial class ServiceSecurityContext {
    public ServiceSecurityContext(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies) { }
    public ServiceSecurityContext(System.IdentityModel.Policy.AuthorizationContext authorizationContext) { }
    public ServiceSecurityContext(System.IdentityModel.Policy.AuthorizationContext authorizationContext, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies) { }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.ServiceSecurityContext Anonymous { get { return default(System.ServiceModel.ServiceSecurityContext); } }
    public System.IdentityModel.Policy.AuthorizationContext AuthorizationContext { get { return default(System.IdentityModel.Policy.AuthorizationContext); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> AuthorizationPolicies { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); } set { } }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.ServiceSecurityContext Current { get { return default(System.ServiceModel.ServiceSecurityContext); } }
    [System.MonoTODOAttribute]
    public bool IsAnonymous { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public System.Security.Principal.IIdentity PrimaryIdentity { get { return default(System.Security.Principal.IIdentity); } }
    [System.MonoTODOAttribute]
    public System.Security.Principal.WindowsIdentity WindowsIdentity { get { return default(System.Security.Principal.WindowsIdentity); } }
  }
  public enum SessionMode {
    Allowed = 0,
    NotAllowed = 2,
    Required = 1,
  }
  public partial class SpnEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public SpnEndpointIdentity(System.IdentityModel.Claims.Claim identity) { }
    public SpnEndpointIdentity(string spn) { }
  }
  public enum TcpClientCredentialType {
    Certificate = 2,
    None = 0,
    Windows = 1,
  }
  [System.MonoTODOAttribute]
  public sealed partial class TcpTransportSecurity {
    internal TcpTransportSecurity() { }
    public System.ServiceModel.TcpClientCredentialType ClientCredentialType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.TcpClientCredentialType); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Security.ProtectionLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class TransactionFlowAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior {
    public TransactionFlowAttribute(System.ServiceModel.TransactionFlowOption transactions) { }
    public System.ServiceModel.TransactionFlowOption Transactions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.TransactionFlowOption); } }
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription description) { }
  }
  public enum TransactionFlowOption {
    Allowed = 1,
    Mandatory = 2,
    NotAllowed = 0,
  }
  public partial class TransactionProtocol {
    protected TransactionProtocol() { }
    public static System.ServiceModel.TransactionProtocol Default { get { return default(System.ServiceModel.TransactionProtocol); } }
    public static System.ServiceModel.TransactionProtocol OleTransactions { get { return default(System.ServiceModel.TransactionProtocol); } }
    public static System.ServiceModel.TransactionProtocol WSAtomicTransactionOctober2004 { get { return default(System.ServiceModel.TransactionProtocol); } }
  }
  public enum TransferMode {
    Buffered = 0,
    Streamed = 1,
    StreamedRequest = 2,
    StreamedResponse = 3,
  }
  public sealed partial class UnknownMessageReceivedEventArgs : System.EventArgs {
    internal UnknownMessageReceivedEventArgs() { }
    public System.ServiceModel.Channels.Message Message { get { return default(System.ServiceModel.Channels.Message); } }
  }
  public partial class UpnEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public UpnEndpointIdentity(System.IdentityModel.Claims.Claim identity) { }
    public UpnEndpointIdentity(string upn) { }
  }
  [System.MonoTODOAttribute("It is untested.")]
  public partial class UriSchemeKeyedCollection : System.Collections.Generic.SynchronizedKeyedCollection<System.String, System.Uri> {
    public UriSchemeKeyedCollection(params System.Uri[] uris) { }
    protected override string GetKeyForItem(System.Uri item) { return default(string); }
    [System.MonoTODOAttribute("hmm, what should I do further?")]
    protected override void InsertItem(int index, System.Uri item) { }
    [System.MonoTODOAttribute("hmm, what should I do further?")]
    protected override void SetItem(int index, System.Uri item) { }
  }
  [System.MonoTODOAttribute]
  public partial class WS2007FederationHttpBinding : System.ServiceModel.WSFederationHttpBinding {
    public WS2007FederationHttpBinding() { }
    public WS2007FederationHttpBinding(System.ServiceModel.WSFederationHttpSecurityMode securityMode) { }
    public WS2007FederationHttpBinding(System.ServiceModel.WSFederationHttpSecurityMode securityMode, bool reliableSessionEnabled) { }
    [System.MonoTODOAttribute]
    public WS2007FederationHttpBinding(string configurationName) { }
  }
  [System.MonoTODOAttribute]
  public partial class WS2007HttpBinding : System.ServiceModel.WSHttpBinding {
    public WS2007HttpBinding() { }
    public WS2007HttpBinding(System.ServiceModel.SecurityMode mode) { }
    public WS2007HttpBinding(System.ServiceModel.SecurityMode mode, bool reliableSessionEnabled) { }
    [System.MonoTODOAttribute]
    public WS2007HttpBinding(string configurationName) { }
  }
  [System.MonoTODOAttribute]
  public partial class WSDualHttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    public WSDualHttpBinding() { }
    protected WSDualHttpBinding(System.ServiceModel.WSDualHttpSecurityMode securityMode) { }
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    public System.Uri ClientBaseAddress { get { return default(System.Uri); } set { } }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public System.ServiceModel.WSMessageEncoding MessageEncoding { get { return default(System.ServiceModel.WSMessageEncoding); } set { } }
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.ServiceModel.ReliableSession ReliableSession { get { return default(System.ServiceModel.ReliableSession); } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.WSDualHttpSecurity Security { get { return default(System.ServiceModel.WSDualHttpSecurity); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    public bool TransactionFlow { get { return default(bool); } set { } }
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public sealed partial class WSDualHttpSecurity {
    internal WSDualHttpSecurity() { }
    [System.MonoTODOAttribute]
    public System.ServiceModel.MessageSecurityOverHttp Message { get { return default(System.ServiceModel.MessageSecurityOverHttp); } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.WSDualHttpSecurityMode Mode { get { return default(System.ServiceModel.WSDualHttpSecurityMode); } set { } }
  }
  public enum WSDualHttpSecurityMode {
    Message = 1,
    None = 0,
  }
  public partial class WSFederationHttpBinding : System.ServiceModel.WSHttpBindingBase {
    public WSFederationHttpBinding() { }
    public WSFederationHttpBinding(System.ServiceModel.WSFederationHttpSecurityMode securityMode) { }
    public WSFederationHttpBinding(System.ServiceModel.WSFederationHttpSecurityMode securityMode, bool reliableSessionEnabled) { }
    [System.MonoTODOAttribute]
    public WSFederationHttpBinding(string configurationName) { }
    [System.MonoTODOAttribute]
    public bool AllowCookies { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public System.Uri PrivacyNoticeAt { get { return default(System.Uri); } set { } }
    [System.MonoTODOAttribute]
    public int PrivacyNoticeVersion { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.WSFederationHttpSecurity Security { get { return default(System.ServiceModel.WSFederationHttpSecurity); } }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.MonoTODOAttribute]
    protected override System.ServiceModel.Channels.SecurityBindingElement CreateMessageSecurity() { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    [System.MonoTODOAttribute]
    protected override System.ServiceModel.Channels.TransportBindingElement GetTransport() { return default(System.ServiceModel.Channels.TransportBindingElement); }
  }
  public sealed partial class WSFederationHttpSecurity {
    internal WSFederationHttpSecurity() { }
    public System.ServiceModel.FederatedMessageSecurityOverHttp Message { get { return default(System.ServiceModel.FederatedMessageSecurityOverHttp); } }
    public System.ServiceModel.WSFederationHttpSecurityMode Mode { get { return default(System.ServiceModel.WSFederationHttpSecurityMode); } set { } }
  }
  public enum WSFederationHttpSecurityMode {
    Message = 1,
    None = 0,
    TransportWithMessageCredential = 2,
  }
  public partial class WSHttpBinding : System.ServiceModel.WSHttpBindingBase {
    public WSHttpBinding() { }
    public WSHttpBinding(System.ServiceModel.SecurityMode mode) { }
    public WSHttpBinding(System.ServiceModel.SecurityMode mode, bool reliableSessionEnabled) { }
    [System.MonoTODOAttribute]
    public WSHttpBinding(string configurationName) { }
    [System.MonoTODOAttribute]
    public bool AllowCookies { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.WSHttpSecurity Security { get { return default(System.ServiceModel.WSHttpSecurity); } }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    [System.MonoTODOAttribute]
    protected override System.ServiceModel.Channels.SecurityBindingElement CreateMessageSecurity() { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    [System.MonoTODOAttribute]
    protected override System.ServiceModel.Channels.TransportBindingElement GetTransport() { return default(System.ServiceModel.Channels.TransportBindingElement); }
  }
  [System.MonoTODOAttribute]
  public abstract partial class WSHttpBindingBase : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences {
    protected WSHttpBindingBase() { }
    protected WSHttpBindingBase(bool reliableSessionEnabled) { }
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    public System.ServiceModel.WSMessageEncoding MessageEncoding { get { return default(System.ServiceModel.WSMessageEncoding); } set { } }
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.ServiceModel.OptionalReliableSession ReliableSession { get { return default(System.ServiceModel.OptionalReliableSession); } }
    public override string Scheme { get { return default(string); } }
    bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { return default(bool); } }
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    public bool TransactionFlow { get { return default(bool); } set { } }
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    protected abstract System.ServiceModel.Channels.SecurityBindingElement CreateMessageSecurity();
    protected abstract System.ServiceModel.Channels.TransportBindingElement GetTransport();
  }
  public sealed partial class WSHttpSecurity {
    internal WSHttpSecurity() { }
    [System.MonoTODOAttribute]
    public System.ServiceModel.NonDualMessageSecurityOverHttp Message { get { return default(System.ServiceModel.NonDualMessageSecurityOverHttp); } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.SecurityMode Mode { get { return default(System.ServiceModel.SecurityMode); } set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.HttpTransportSecurity Transport { get { return default(System.ServiceModel.HttpTransportSecurity); } }
  }
  public enum WSMessageEncoding {
    Mtom = 1,
    Text = 0,
  }
  public partial class X509CertificateEndpointIdentity : System.ServiceModel.EndpointIdentity {
    public X509CertificateEndpointIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 cert) { }
    public X509CertificateEndpointIdentity(System.Security.Cryptography.X509Certificates.X509Certificate2 primaryCertificate, System.Security.Cryptography.X509Certificates.X509Certificate2Collection supportingCertificates) { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2Collection); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1092), Inherited=false)]
  public sealed partial class XmlSerializerFormatAttribute : System.Attribute {
    public XmlSerializerFormatAttribute() { }
    public System.ServiceModel.OperationFormatStyle Style { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.OperationFormatStyle); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool SupportFaults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.OperationFormatUse Use { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.OperationFormatUse); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
namespace System.ServiceModel.Activation {
  [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
  [System.MonoTODOAttribute]
  public sealed partial class AspNetCompatibilityRequirementsAttribute : System.Attribute, System.ServiceModel.Description.IServiceBehavior {
    public AspNetCompatibilityRequirementsAttribute() { }
    public System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode RequirementsMode { get { return default(System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode); } set { } }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public enum AspNetCompatibilityRequirementsMode {
    Allowed = 1,
    NotAllowed = 0,
    Required = 2,
  }
  public abstract partial class HostedTransportConfiguration {
    protected HostedTransportConfiguration() { }
    public abstract System.Uri[] GetBaseAddresses(string virtualPath);
  }
  public partial class ServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactoryBase {
    public ServiceHostFactory() { }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.ServiceHostBase CreateServiceHost(string constructorString, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHostBase); }
    [System.MonoTODOAttribute("untested")]
    protected virtual System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHost); }
  }
  public abstract partial class ServiceHostFactoryBase {
    protected ServiceHostFactoryBase() { }
    public abstract System.ServiceModel.ServiceHostBase CreateServiceHost(string constructorString, System.Uri[] baseAddresses);
  }
  public sealed partial class VirtualPathExtension : System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase> {
    internal VirtualPathExtension() { }
    public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public void Attach(System.ServiceModel.ServiceHostBase owner) { }
    public void Detach(System.ServiceModel.ServiceHostBase owner) { }
  }
}
namespace System.ServiceModel.Activation.Configuration {
  public partial class Dummy {
    public Dummy() { }
  }
}
namespace System.ServiceModel.Channels {
  public abstract partial class AddressHeader {
    protected AddressHeader() { }
    public abstract string Name { get; }
    public abstract string Namespace { get; }
    public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(object value) { return default(System.ServiceModel.Channels.AddressHeader); }
    public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(object value, System.Runtime.Serialization.XmlObjectSerializer formatter) { return default(System.ServiceModel.Channels.AddressHeader); }
    public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(string name, string ns, object value) { return default(System.ServiceModel.Channels.AddressHeader); }
    public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer formatter) { return default(System.ServiceModel.Channels.AddressHeader); }
    public override bool Equals(object obj) { return default(bool); }
    public virtual System.Xml.XmlDictionaryReader GetAddressHeaderReader() { return default(System.Xml.XmlDictionaryReader); }
    public override int GetHashCode() { return default(int); }
    public T GetValue<T>() { return default(T); }
    public T GetValue<T>(System.Runtime.Serialization.XmlObjectSerializer formatter) { return default(T); }
    protected abstract void OnWriteAddressHeaderContents(System.Xml.XmlDictionaryWriter writer);
    protected virtual void OnWriteStartAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
    public System.ServiceModel.Channels.MessageHeader ToMessageHeader() { return default(System.ServiceModel.Channels.MessageHeader); }
    public void WriteAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteAddressHeader(System.Xml.XmlWriter writer) { }
    public void WriteAddressHeaderContents(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteStartAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
  }
  public sealed partial class AddressHeaderCollection : System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Channels.AddressHeader> {
    public AddressHeaderCollection() : base (default(System.Collections.Generic.IList<System.ServiceModel.Channels.AddressHeader>)) { }
    public AddressHeaderCollection(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.AddressHeader> headers) : base (default(System.Collections.Generic.IList<System.ServiceModel.Channels.AddressHeader>)) { }
    public void AddHeadersTo(System.ServiceModel.Channels.Message message) { }
    public System.ServiceModel.Channels.AddressHeader[] FindAll(string name, string ns) { return default(System.ServiceModel.Channels.AddressHeader[]); }
    public System.ServiceModel.Channels.AddressHeader FindHeader(string name, string ns) { return default(System.ServiceModel.Channels.AddressHeader); }
  }
  public sealed partial class AddressingVersion {
    internal AddressingVersion() { }
    public static System.ServiceModel.Channels.AddressingVersion None { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public static System.ServiceModel.Channels.AddressingVersion WSAddressing10 { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public static System.ServiceModel.Channels.AddressingVersion WSAddressingAugust2004 { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public override string ToString() { return default(string); }
  }
  public sealed partial class AsymmetricSecurityBindingElement : System.ServiceModel.Channels.SecurityBindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public AsymmetricSecurityBindingElement() { }
    public AsymmetricSecurityBindingElement(System.ServiceModel.Security.Tokens.SecurityTokenParameters recipientTokenParameters) { }
    public AsymmetricSecurityBindingElement(System.ServiceModel.Security.Tokens.SecurityTokenParameters recipientTokenParameters, System.ServiceModel.Security.Tokens.SecurityTokenParameters initiatorTokenParameters) { }
    public bool AllowSerializedSigningTokenOnReply { get { return default(bool); } set { } }
    public System.ServiceModel.Security.Tokens.SecurityTokenParameters InitiatorTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); } set { } }
    public System.ServiceModel.Security.MessageProtectionOrder MessageProtectionOrder { get { return default(System.ServiceModel.Security.MessageProtectionOrder); } set { } }
    public System.ServiceModel.Security.Tokens.SecurityTokenParameters RecipientTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); } set { } }
    public bool RequireSignatureConfirmation { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.MonoTODOAttribute]
    protected override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    public override void SetKeyDerivation(bool requireDerivedKeys) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext policyContext) { }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class BinaryMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public BinaryMessageEncodingBindingElement() { }
    public int MaxReadPoolSize { get { return default(int); } set { } }
    public int MaxSessionSize { get { return default(int); } set { } }
    public int MaxWritePoolSize { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public abstract partial class Binding : System.ServiceModel.IDefaultCommunicationTimeouts {
    protected Binding() { }
    protected Binding(string name, string ns) { }
    public System.TimeSpan CloseTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.TimeSpan OpenTimeout { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan ReceiveTimeout { get { return default(System.TimeSpan); } set { } }
    public abstract string Scheme { get; }
    public System.TimeSpan SendTimeout { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(params System.Object[] parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(params System.Object[] parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUri, params System.Object[] parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUri, System.ServiceModel.Channels.BindingParameterCollection parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUriBaseAddress, string listenUriRelativeAddress, params System.Object[] parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUriBaseAddress, string listenUriRelativeAddress, System.ServiceModel.Channels.BindingParameterCollection parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUriBaseAddress, string listenUriRelativeAddress, System.ServiceModel.Description.ListenUriMode listenUriMode, params System.Object[] parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.Uri listenUriBaseAddress, string listenUriRelativeAddress, System.ServiceModel.Description.ListenUriMode listenUriMode, System.ServiceModel.Channels.BindingParameterCollection parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public bool CanBuildChannelFactory<TChannel>(params System.Object[] parameters) { return default(bool); }
    public virtual bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { return default(bool); }
    public bool CanBuildChannelListener<TChannel>(params System.Object[] parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(bool); }
    public virtual bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(bool); }
    public abstract System.ServiceModel.Channels.BindingElementCollection CreateBindingElements();
    public T GetProperty<T>(System.ServiceModel.Channels.BindingParameterCollection parameters) where T : class { return default(T); }
  }
  public partial class BindingContext {
    public BindingContext(System.ServiceModel.Channels.CustomBinding binding, System.ServiceModel.Channels.BindingParameterCollection parms) { }
    public BindingContext(System.ServiceModel.Channels.CustomBinding binding, System.ServiceModel.Channels.BindingParameterCollection parameters, System.Uri listenUriBaseAddress, string listenUriRelativeAddress, System.ServiceModel.Description.ListenUriMode listenUriMode) { }
    public System.ServiceModel.Channels.CustomBinding Binding { get { return default(System.ServiceModel.Channels.CustomBinding); } }
    public System.ServiceModel.Channels.BindingParameterCollection BindingParameters { get { return default(System.ServiceModel.Channels.BindingParameterCollection); } }
    public System.Uri ListenUriBaseAddress { get { return default(System.Uri); } set { } }
    public System.ServiceModel.Description.ListenUriMode ListenUriMode { get { return default(System.ServiceModel.Description.ListenUriMode); } set { } }
    public string ListenUriRelativeAddress { get { return default(string); } set { } }
    public System.ServiceModel.Channels.BindingElementCollection RemainingBindingElements { get { return default(System.ServiceModel.Channels.BindingElementCollection); } }
    public System.ServiceModel.Channels.IChannelFactory<TChannel> BuildInnerChannelFactory<TChannel>() { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public System.ServiceModel.Channels.IChannelListener<TChannel> BuildInnerChannelListener<TChannel>() where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public bool CanBuildInnerChannelFactory<TChannel>() { return default(bool); }
    public bool CanBuildInnerChannelListener<TChannel>() where TChannel : class, System.ServiceModel.Channels.IChannel { return default(bool); }
    public System.ServiceModel.Channels.BindingContext Clone() { return default(System.ServiceModel.Channels.BindingContext); }
    public T GetInnerProperty<T>() where T : class { return default(T); }
  }
  public abstract partial class BindingElement {
    protected BindingElement() { }
    [System.MonoTODOAttribute]
    protected BindingElement(System.ServiceModel.Channels.BindingElement other) { }
    public virtual System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public virtual System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public virtual bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public virtual bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) where TChannel : class, System.ServiceModel.Channels.IChannel { return default(bool); }
    public abstract System.ServiceModel.Channels.BindingElement Clone();
    public abstract T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) where T : class;
  }
  [System.MonoTODOAttribute]
  public partial class BindingElementCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.BindingElement> {
    public BindingElementCollection() { }
    public BindingElementCollection(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.BindingElement> bindings) { }
    public BindingElementCollection(System.ServiceModel.Channels.BindingElement[] bindings) { }
    public void AddRange(params System.ServiceModel.Channels.BindingElement[] elements) { }
    public System.ServiceModel.Channels.BindingElementCollection Clone() { return default(System.ServiceModel.Channels.BindingElementCollection); }
    public bool Contains(System.Type bindingElementType) { return default(bool); }
    public T Find<T>() { return default(T); }
    public System.Collections.ObjectModel.Collection<T> FindAll<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    protected override void InsertItem(int index, System.ServiceModel.Channels.BindingElement item) { }
    public T Remove<T>() { return default(T); }
    public System.Collections.ObjectModel.Collection<T> RemoveAll<T>() { return default(System.Collections.ObjectModel.Collection<T>); }
    protected override void SetItem(int index, System.ServiceModel.Channels.BindingElement item) { }
  }
  public partial class BindingParameterCollection : System.Collections.Generic.KeyedByTypeCollection<System.Object> {
    public BindingParameterCollection() { }
  }
  public abstract partial class BodyWriter {
    protected BodyWriter(bool isBuffered) { }
    public bool IsBuffered { get { return default(bool); } }
    public System.ServiceModel.Channels.BodyWriter CreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.BodyWriter); }
    protected virtual System.ServiceModel.Channels.BodyWriter OnCreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.BodyWriter); }
    protected abstract void OnWriteBodyContents(System.Xml.XmlDictionaryWriter writer);
    public void WriteBodyContents(System.Xml.XmlDictionaryWriter writer) { }
  }
  public abstract partial class BufferManager {
    protected BufferManager() { }
    public abstract void Clear();
    public static System.ServiceModel.Channels.BufferManager CreateBufferManager(long maxBufferPoolSize, int maxBufferSize) { return default(System.ServiceModel.Channels.BufferManager); }
    public abstract void ReturnBuffer(System.Byte[] buffer);
    public abstract System.Byte[] TakeBuffer(int bufferSize);
  }
  [System.MonoTODOAttribute]
  public abstract partial class ChannelBase : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IDefaultCommunicationTimeouts {
    protected ChannelBase(System.ServiceModel.Channels.ChannelManagerBase manager) { }
    protected internal override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    protected internal System.TimeSpan DefaultReceiveTimeout { get { return default(System.TimeSpan); } }
    protected internal System.TimeSpan DefaultSendTimeout { get { return default(System.TimeSpan); } }
    protected System.ServiceModel.Channels.ChannelManagerBase Manager { get { return default(System.ServiceModel.Channels.ChannelManagerBase); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get { return default(System.TimeSpan); } }
    public virtual T GetProperty<T>() where T : class { return default(T); }
    protected override void OnClosed() { }
  }
  public abstract partial class ChannelFactoryBase : System.ServiceModel.Channels.ChannelManagerBase, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject {
    protected ChannelFactoryBase() { }
    protected ChannelFactoryBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    protected internal override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultReceiveTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultSendTimeout { get { return default(System.TimeSpan); } }
    public virtual T GetProperty<T>() where T : class { return default(T); }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnEndClose(System.IAsyncResult result) { }
  }
  public abstract partial class ChannelFactoryBase<TChannel> : System.ServiceModel.Channels.ChannelFactoryBase, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.Channels.IChannelFactory<TChannel>, System.ServiceModel.ICommunicationObject {
    protected ChannelFactoryBase() { }
    protected ChannelFactoryBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    public TChannel CreateChannel(System.ServiceModel.EndpointAddress remoteAddress) { return default(TChannel); }
    public TChannel CreateChannel(System.ServiceModel.EndpointAddress remoteAddress, System.Uri via) { return default(TChannel); }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected abstract TChannel OnCreateChannel(System.ServiceModel.EndpointAddress remoteAddress, System.Uri via);
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected void ValidateCreateChannel() { }
  }
  [System.MonoTODOAttribute]
  public abstract partial class ChannelListenerBase : System.ServiceModel.Channels.ChannelManagerBase, System.ServiceModel.Channels.IChannelListener, System.ServiceModel.ICommunicationObject, System.ServiceModel.IDefaultCommunicationTimeouts {
    protected ChannelListenerBase() { }
    protected ChannelListenerBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    protected internal override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultReceiveTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultSendTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get { return default(System.TimeSpan); } }
    public abstract System.Uri Uri { get; }
    public System.IAsyncResult BeginWaitForChannel(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public bool EndWaitForChannel(System.IAsyncResult result) { return default(bool); }
    public virtual T GetProperty<T>() where T : class { return default(T); }
    protected abstract System.IAsyncResult OnBeginWaitForChannel(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract bool OnEndWaitForChannel(System.IAsyncResult result);
    protected abstract bool OnWaitForChannel(System.TimeSpan timeout);
    public bool WaitForChannel(System.TimeSpan timeout) { return default(bool); }
  }
  public abstract partial class ChannelListenerBase<TChannel> : System.ServiceModel.Channels.ChannelListenerBase, System.ServiceModel.Channels.IChannelListener, System.ServiceModel.Channels.IChannelListener<TChannel>, System.ServiceModel.ICommunicationObject where TChannel : class, System.ServiceModel.Channels.IChannel {
    protected ChannelListenerBase() { }
    protected ChannelListenerBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    public TChannel AcceptChannel() { return default(TChannel); }
    public TChannel AcceptChannel(System.TimeSpan timeout) { return default(TChannel); }
    public System.IAsyncResult BeginAcceptChannel(System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginAcceptChannel(System.TimeSpan timeout, System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public TChannel EndAcceptChannel(System.IAsyncResult result) { return default(TChannel); }
    protected abstract TChannel OnAcceptChannel(System.TimeSpan timeout);
    protected abstract System.IAsyncResult OnBeginAcceptChannel(System.TimeSpan timeout, System.AsyncCallback callback, object asyncState);
    protected abstract TChannel OnEndAcceptChannel(System.IAsyncResult result);
  }
  public abstract partial class ChannelManagerBase : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.ICommunicationObject, System.ServiceModel.IDefaultCommunicationTimeouts {
    protected ChannelManagerBase() { }
    protected internal abstract System.TimeSpan DefaultReceiveTimeout { get; }
    protected internal abstract System.TimeSpan DefaultSendTimeout { get; }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get { return default(System.TimeSpan); } }
    System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get { return default(System.TimeSpan); } }
  }
  public partial class ChannelParameterCollection : System.Collections.ObjectModel.Collection<System.Object> {
    public ChannelParameterCollection() { }
    public ChannelParameterCollection(System.ServiceModel.Channels.IChannel channel) { }
    protected virtual System.ServiceModel.Channels.IChannel Channel { get { return default(System.ServiceModel.Channels.IChannel); } }
    protected override void ClearItems() { }
    protected override void InsertItem(int index, object item) { }
    public void PropagateChannelParameters(System.ServiceModel.Channels.IChannel innerChannel) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, object item) { }
  }
  public partial class ChannelPoolSettings {
    [System.MonoTODOAttribute]
    public ChannelPoolSettings() { }
    [System.MonoTODOAttribute]
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    [System.MonoTODOAttribute]
    public System.TimeSpan LeaseTimeout { get { return default(System.TimeSpan); } set { } }
    [System.MonoTODOAttribute]
    public int MaxOutboundChannelsPerEndpoint { get { return default(int); } set { } }
  }
  public abstract partial class CommunicationObject : System.ServiceModel.ICommunicationObject {
    protected CommunicationObject() { }
    protected CommunicationObject(object mutex) { }
    protected internal abstract System.TimeSpan DefaultCloseTimeout { get; }
    protected internal abstract System.TimeSpan DefaultOpenTimeout { get; }
    protected bool IsDisposed { get { return default(bool); } }
    public System.ServiceModel.CommunicationState State { get { return default(System.ServiceModel.CommunicationState); } }
    protected object ThisLock { get { return default(object); } }
    public event System.EventHandler Closed { add { } remove { } }
    public event System.EventHandler Closing { add { } remove { } }
    public event System.EventHandler Faulted { add { } remove { } }
    public event System.EventHandler Opened { add { } remove { } }
    public event System.EventHandler Opening { add { } remove { } }
    public void Abort() { }
    public System.IAsyncResult BeginClose(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginOpen(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Close() { }
    public void Close(System.TimeSpan timeout) { }
    public void EndClose(System.IAsyncResult result) { }
    public void EndOpen(System.IAsyncResult result) { }
    protected void Fault() { }
    protected virtual System.Type GetCommunicationObjectType() { return default(System.Type); }
    protected abstract void OnAbort();
    protected abstract System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    protected abstract void OnClose(System.TimeSpan timeout);
    protected virtual void OnClosed() { }
    protected virtual void OnClosing() { }
    protected abstract void OnEndClose(System.IAsyncResult result);
    protected abstract void OnEndOpen(System.IAsyncResult result);
    protected virtual void OnFaulted() { }
    protected abstract void OnOpen(System.TimeSpan timeout);
    protected virtual void OnOpened() { }
    protected virtual void OnOpening() { }
    public void Open() { }
    public void Open(System.TimeSpan timeout) { }
    protected void ThrowIfDisposed() { }
    protected void ThrowIfDisposedOrImmutable() { }
    protected void ThrowIfDisposedOrNotOpen() { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class CompositeDuplexBindingElement : System.ServiceModel.Channels.BindingElement {
    public CompositeDuplexBindingElement() { }
    public System.Uri ClientBaseAddress { get { return default(System.Uri); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public sealed partial class CompositeDuplexBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public CompositeDuplexBindingElementImporter() { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  [System.MonoTODOAttribute]
  public abstract partial class ConnectionOrientedTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    internal ConnectionOrientedTransportBindingElement() { }
    public System.TimeSpan ChannelInitializationTimeout { get { return default(System.TimeSpan); } set { } }
    public int ConnectionBufferSize { get { return default(int); } set { } }
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public int MaxBufferSize { get { return default(int); } set { } }
    public System.TimeSpan MaxOutputDelay { get { return default(System.TimeSpan); } set { } }
    public int MaxPendingAccepts { get { return default(int); } set { } }
    public int MaxPendingConnections { get { return default(int); } set { } }
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public partial class CustomBinding : System.ServiceModel.Channels.Binding {
    public CustomBinding() { }
    public CustomBinding(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.BindingElement> bindingElements) { }
    public CustomBinding(System.ServiceModel.Channels.Binding binding) { }
    public CustomBinding(params System.ServiceModel.Channels.BindingElement[] binding) { }
    public CustomBinding(string name) { }
    public CustomBinding(string name, string ns, params System.ServiceModel.Channels.BindingElement[] binding) { }
    public System.ServiceModel.Channels.BindingElementCollection Elements { get { return default(System.ServiceModel.Channels.BindingElementCollection); } }
    public override string Scheme { get { return default(string); } }
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public enum DeliveryFailure {
    AccessDenied = 32772,
    BadDestinationQueue = 32768,
    BadEncryption = 32775,
    BadSignature = 32774,
    CouldNotEncrypt = 32776,
    HopCountExceeded = 32773,
    NotTransactionalMessage = 32778,
    NotTransactionalQueue = 32777,
    Purged = 32769,
    QueueDeleted = 49152,
    QueueExceedMaximumSize = 32771,
    QueuePurged = 49153,
    ReachQueueTimeout = 32770,
    ReceiveTimeout = 49154,
    Unknown = 0,
  }
  public enum DeliveryStatus {
    InDoubt = 0,
    NotDelivered = 1,
  }
  public abstract partial class FaultConverter {
    protected FaultConverter() { }
    public static System.ServiceModel.Channels.FaultConverter GetDefaultFaultConverter(System.ServiceModel.Channels.MessageVersion version) { return default(System.ServiceModel.Channels.FaultConverter); }
    [System.MonoTODOAttribute]
    protected abstract bool OnTryCreateException(System.ServiceModel.Channels.Message message, System.ServiceModel.Channels.MessageFault fault, out System.Exception error);
    [System.MonoTODOAttribute]
    protected abstract bool OnTryCreateFaultMessage(System.Exception error, out System.ServiceModel.Channels.Message message);
    public bool TryCreateException(System.ServiceModel.Channels.Message message, System.ServiceModel.Channels.MessageFault fault, out System.Exception error) { error = default(System.Exception); return default(bool); }
    public bool TryCreateFaultMessage(System.Exception error, out System.ServiceModel.Channels.Message message) { message = default(System.ServiceModel.Channels.Message); return default(bool); }
  }
  public sealed partial class HttpRequestMessageProperty {
    public HttpRequestMessageProperty() { }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public string Method { get { return default(string); } set { } }
    public static string Name { get { return default(string); } }
    public string QueryString { get { return default(string); } set { } }
    public bool SuppressEntityBody { get { return default(bool); } set { } }
  }
  public sealed partial class HttpResponseMessageProperty {
    public HttpResponseMessageProperty() { }
    public System.Net.WebHeaderCollection Headers { get { return default(System.Net.WebHeaderCollection); } }
    public static string Name { get { return default(string); } }
    public System.Net.HttpStatusCode StatusCode { get { return default(System.Net.HttpStatusCode); } set { } }
    public string StatusDescription { get { return default(string); } set { } }
    public bool SuppressEntityBody { get { return default(bool); } set { } }
  }
  [System.MonoTODOAttribute]
  public partial class HttpsTransportBindingElement : System.ServiceModel.Channels.HttpTransportBindingElement, System.ServiceModel.Channels.ITransportTokenAssertionProvider, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public HttpsTransportBindingElement() { }
    protected HttpsTransportBindingElement(System.ServiceModel.Channels.HttpsTransportBindingElement other) { }
    public bool RequireClientCertificate { get { return default(bool); } set { } }
    public override string Scheme { get { return default(string); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    public System.Xml.XmlElement GetTransportTokenAssertion() { return default(System.Xml.XmlElement); }
  }
  public partial class HttpTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public HttpTransportBindingElement() { }
    protected HttpTransportBindingElement(System.ServiceModel.Channels.HttpTransportBindingElement other) { }
    public bool AllowCookies { get { return default(bool); } set { } }
    public System.Net.AuthenticationSchemes AuthenticationScheme { get { return default(System.Net.AuthenticationSchemes); } set { } }
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    public bool KeepAliveEnabled { get { return default(bool); } set { } }
    public int MaxBufferSize { get { return default(int); } set { } }
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    public System.Net.AuthenticationSchemes ProxyAuthenticationScheme { get { return default(System.Net.AuthenticationSchemes); } set { } }
    public string Realm { get { return default(string); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public bool UnsafeConnectionNtlmAuthentication { get { return default(bool); } set { } }
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public partial interface IBindingDeliveryCapabilities {
    bool AssuresOrderedDelivery { get; }
    bool QueuedDelivery { get; }
  }
  public partial interface IBindingMulticastCapabilities {
    bool IsMulticast { get; }
  }
  public partial interface IBindingRuntimePreferences {
    bool ReceiveSynchronously { get; }
  }
  public partial interface IChannel : System.ServiceModel.ICommunicationObject {
    T GetProperty<T>() where T : class;
  }
  public partial interface IChannelFactory : System.ServiceModel.ICommunicationObject {
    T GetProperty<T>() where T : class;
  }
  public partial interface IChannelFactory<TChannel> : System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject {
    TChannel CreateChannel(System.ServiceModel.EndpointAddress to);
    TChannel CreateChannel(System.ServiceModel.EndpointAddress to, System.Uri via);
  }
  public partial interface IChannelListener : System.ServiceModel.ICommunicationObject {
    System.Uri Uri { get; }
    System.IAsyncResult BeginWaitForChannel(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    bool EndWaitForChannel(System.IAsyncResult result);
    T GetProperty<T>() where T : class;
    bool WaitForChannel(System.TimeSpan timeout);
  }
  public partial interface IChannelListener<TChannel> : System.ServiceModel.Channels.IChannelListener, System.ServiceModel.ICommunicationObject where TChannel : class, System.ServiceModel.Channels.IChannel {
    TChannel AcceptChannel();
    TChannel AcceptChannel(System.TimeSpan timeout);
    System.IAsyncResult BeginAcceptChannel(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginAcceptChannel(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    TChannel EndAcceptChannel(System.IAsyncResult result);
  }
  public partial interface IDuplexChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.ICommunicationObject {
  }
  public partial interface IDuplexSession : System.ServiceModel.Channels.IInputSession, System.ServiceModel.Channels.IOutputSession, System.ServiceModel.Channels.ISession {
    System.IAsyncResult BeginCloseOutputSession(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginCloseOutputSession(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void CloseOutputSession();
    void CloseOutputSession(System.TimeSpan timeout);
    void EndCloseOutputSession(System.IAsyncResult result);
  }
  public partial interface IDuplexSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IDuplexChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IDuplexSession>, System.ServiceModel.ICommunicationObject {
  }
  public partial interface IInputChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress LocalAddress { get; }
    System.IAsyncResult BeginReceive(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginReceive(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginTryReceive(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginWaitForMessage(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.ServiceModel.Channels.Message EndReceive(System.IAsyncResult result);
    bool EndTryReceive(System.IAsyncResult result, out System.ServiceModel.Channels.Message message);
    bool EndWaitForMessage(System.IAsyncResult result);
    System.ServiceModel.Channels.Message Receive();
    System.ServiceModel.Channels.Message Receive(System.TimeSpan timeout);
    bool TryReceive(System.TimeSpan timeout, out System.ServiceModel.Channels.Message message);
    bool WaitForMessage(System.TimeSpan timeout);
  }
  public partial interface IInputSession : System.ServiceModel.Channels.ISession {
  }
  public partial interface IInputSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IInputSession>, System.ServiceModel.ICommunicationObject {
  }
  public partial interface IMessageProperty {
    System.ServiceModel.Channels.IMessageProperty CreateCopy();
  }
  public partial class InvalidChannelBindingException : System.Exception {
    [System.MonoTODOAttribute]
    public InvalidChannelBindingException() { }
    public InvalidChannelBindingException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public InvalidChannelBindingException(string message) { }
    public InvalidChannelBindingException(string message, System.Exception innerException) { }
  }
  public partial interface IOutputChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress RemoteAddress { get; }
    System.Uri Via { get; }
    System.IAsyncResult BeginSend(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginSend(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    void EndSend(System.IAsyncResult result);
    void Send(System.ServiceModel.Channels.Message message);
    void Send(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
  }
  public partial interface IOutputSession : System.ServiceModel.Channels.ISession {
  }
  public partial interface IOutputSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IOutputSession>, System.ServiceModel.ICommunicationObject {
  }
  public partial interface IReplyChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress LocalAddress { get; }
    System.IAsyncResult BeginReceiveRequest(System.AsyncCallback callback, object state);
    System.IAsyncResult BeginReceiveRequest(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginTryReceiveRequest(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginWaitForRequest(System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.ServiceModel.Channels.RequestContext EndReceiveRequest(System.IAsyncResult result);
    bool EndTryReceiveRequest(System.IAsyncResult result, out System.ServiceModel.Channels.RequestContext context);
    bool EndWaitForRequest(System.IAsyncResult result);
    System.ServiceModel.Channels.RequestContext ReceiveRequest();
    System.ServiceModel.Channels.RequestContext ReceiveRequest(System.TimeSpan timeout);
    bool TryReceiveRequest(System.TimeSpan timeout, out System.ServiceModel.Channels.RequestContext context);
    bool WaitForRequest(System.TimeSpan timeout);
  }
  public partial interface IReplySessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IReplyChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IInputSession>, System.ServiceModel.ICommunicationObject {
  }
  public partial interface IRequestChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject {
    System.ServiceModel.EndpointAddress RemoteAddress { get; }
    System.Uri Via { get; }
    System.IAsyncResult BeginRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    System.IAsyncResult BeginRequest(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    System.ServiceModel.Channels.Message EndRequest(System.IAsyncResult result);
    System.ServiceModel.Channels.Message Request(System.ServiceModel.Channels.Message message);
    System.ServiceModel.Channels.Message Request(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
  }
  public partial interface IRequestSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IRequestChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IOutputSession>, System.ServiceModel.ICommunicationObject {
  }
  public partial interface ISecurityCapabilities {
    System.Net.Security.ProtectionLevel SupportedRequestProtectionLevel { get; }
    System.Net.Security.ProtectionLevel SupportedResponseProtectionLevel { get; }
    bool SupportsClientAuthentication { get; }
    bool SupportsClientWindowsIdentity { get; }
    bool SupportsServerAuthentication { get; }
  }
  public partial interface ISession {
    string Id { get; }
  }
  public partial interface ISessionChannel<TSession> where TSession : System.ServiceModel.Channels.ISession {
    TSession Session { get; }
  }
  public partial interface ITransactedBindingElement {
    bool TransactedReceiveEnabled { get; }
  }
  public partial interface ITransportTokenAssertionProvider {
    System.Xml.XmlElement GetTransportTokenAssertion();
  }
  [System.MonoTODOAttribute]
  public sealed partial class LocalClientSecuritySettings {
    public LocalClientSecuritySettings() { }
    public bool CacheCookies { get { return default(bool); } set { } }
    public int CookieRenewalThresholdPercentage { get { return default(int); } set { } }
    public bool DetectReplays { get { return default(bool); } set { } }
    public System.ServiceModel.Security.IdentityVerifier IdentityVerifier { get { return default(System.ServiceModel.Security.IdentityVerifier); } set { } }
    public System.TimeSpan MaxClockSkew { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan MaxCookieCachingTime { get { return default(System.TimeSpan); } set { } }
    public bool ReconnectTransportOnFailure { get { return default(bool); } set { } }
    public int ReplayCacheSize { get { return default(int); } set { } }
    public System.TimeSpan ReplayWindow { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan SessionKeyRenewalInterval { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan SessionKeyRolloverInterval { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan TimestampValidityDuration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute("What happens to IdentityVerifier?")]
    public System.ServiceModel.Channels.LocalClientSecuritySettings Clone() { return default(System.ServiceModel.Channels.LocalClientSecuritySettings); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class LocalServiceSecuritySettings {
    public LocalServiceSecuritySettings() { }
    public bool DetectReplays { get { return default(bool); } set { } }
    public System.TimeSpan InactivityTimeout { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan IssuedCookieLifetime { get { return default(System.TimeSpan); } set { } }
    public int MaxCachedCookies { get { return default(int); } set { } }
    public System.TimeSpan MaxClockSkew { get { return default(System.TimeSpan); } set { } }
    public int MaxPendingSessions { get { return default(int); } set { } }
    public int MaxStatefulNegotiations { get { return default(int); } set { } }
    public System.TimeSpan NegotiationTimeout { get { return default(System.TimeSpan); } set { } }
    public bool ReconnectTransportOnFailure { get { return default(bool); } set { } }
    public int ReplayCacheSize { get { return default(int); } set { } }
    public System.TimeSpan ReplayWindow { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan SessionKeyRenewalInterval { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan SessionKeyRolloverInterval { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan TimestampValidityDuration { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.Channels.LocalServiceSecuritySettings Clone() { return default(System.ServiceModel.Channels.LocalServiceSecuritySettings); }
  }
  public abstract partial class Message : System.IDisposable {
    protected Message() { }
    public abstract System.ServiceModel.Channels.MessageHeaders Headers { get; }
    protected bool IsDisposed { get { return default(bool); } }
    public virtual bool IsEmpty { get { return default(bool); } }
    public virtual bool IsFault { get { return default(bool); } }
    public abstract System.ServiceModel.Channels.MessageProperties Properties { get; }
    public System.ServiceModel.Channels.MessageState State { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.MessageState); } }
    public abstract System.ServiceModel.Channels.MessageVersion Version { get; }
    public void Close() { }
    public System.ServiceModel.Channels.MessageBuffer CreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.MessageBuffer); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, System.ServiceModel.Channels.MessageFault fault, string action) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, System.ServiceModel.FaultCode code, string reason, object detail, string action) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, System.ServiceModel.FaultCode code, string reason, string action) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, object body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, object body, System.Runtime.Serialization.XmlObjectSerializer xmlFormatter) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.ServiceModel.Channels.BodyWriter body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.Xml.XmlDictionaryReader body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.Xml.XmlReader body) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.Xml.XmlDictionaryReader envelopeReader, int maxSizeOfHeaders, System.ServiceModel.Channels.MessageVersion version) { return default(System.ServiceModel.Channels.Message); }
    public static System.ServiceModel.Channels.Message CreateMessage(System.Xml.XmlReader envelopeReader, int maxSizeOfHeaders, System.ServiceModel.Channels.MessageVersion version) { return default(System.ServiceModel.Channels.Message); }
    public T GetBody<T>() { return default(T); }
    public T GetBody<T>(System.Runtime.Serialization.XmlObjectSerializer xmlFormatter) { return default(T); }
    public string GetBodyAttribute(string localName, string ns) { return default(string); }
    public System.Xml.XmlDictionaryReader GetReaderAtBodyContents() { return default(System.Xml.XmlDictionaryReader); }
    protected virtual void OnBodyToString(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnClose() { }
    protected virtual System.ServiceModel.Channels.MessageBuffer OnCreateBufferedCopy(int maxBufferSize) { return default(System.ServiceModel.Channels.MessageBuffer); }
    protected virtual string OnGetBodyAttribute(string localName, string ns) { return default(string); }
    protected virtual System.Xml.XmlDictionaryReader OnGetReaderAtBodyContents() { return default(System.Xml.XmlDictionaryReader); }
    protected abstract void OnWriteBodyContents(System.Xml.XmlDictionaryWriter writer);
    protected virtual void OnWriteMessage(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnWriteStartBody(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnWriteStartEnvelope(System.Xml.XmlDictionaryWriter writer) { }
    protected virtual void OnWriteStartHeaders(System.Xml.XmlDictionaryWriter writer) { }
    void System.IDisposable.Dispose() { }
    public override string ToString() { return default(string); }
    public void WriteBody(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteBody(System.Xml.XmlWriter writer) { }
    public void WriteBodyContents(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteMessage(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteMessage(System.Xml.XmlWriter writer) { }
    public void WriteStartBody(System.Xml.XmlDictionaryWriter writer) { }
    public void WriteStartBody(System.Xml.XmlWriter writer) { }
    public void WriteStartEnvelope(System.Xml.XmlDictionaryWriter writer) { }
  }
  public abstract partial class MessageBuffer : System.IDisposable, System.Xml.XPath.IXPathNavigable {
    protected MessageBuffer() { }
    public abstract int BufferSize { get; }
    public virtual string MessageContentType { get { return default(string); } }
    public abstract void Close();
    public abstract System.ServiceModel.Channels.Message CreateMessage();
    public System.Xml.XPath.XPathNavigator CreateNavigator() { return default(System.Xml.XPath.XPathNavigator); }
    public System.Xml.XPath.XPathNavigator CreateNavigator(int node_quota) { return default(System.Xml.XPath.XPathNavigator); }
    [System.MonoTODOAttribute("Handle node_quota and xmlspace")]
    public System.Xml.XPath.XPathNavigator CreateNavigator(int node_quota, System.Xml.XmlSpace space) { return default(System.Xml.XPath.XPathNavigator); }
    [System.MonoTODOAttribute("supply proper quota")]
    public System.Xml.XPath.XPathNavigator CreateNavigator(System.Xml.XmlSpace space) { return default(System.Xml.XPath.XPathNavigator); }
    void System.IDisposable.Dispose() { }
    public virtual void WriteMessage(System.IO.Stream stream) { }
  }
  public abstract partial class MessageEncoder {
    protected MessageEncoder() { }
    public abstract string ContentType { get; }
    public abstract string MediaType { get; }
    public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; }
    [System.MonoTODOAttribute]
    public virtual T GetProperty<T>() where T : class { return default(T); }
    public virtual bool IsContentTypeSupported(string contentType) { return default(bool); }
    public System.ServiceModel.Channels.Message ReadMessage(System.ArraySegment<System.Byte> buffer, System.ServiceModel.Channels.BufferManager bufferManager) { return default(System.ServiceModel.Channels.Message); }
    public abstract System.ServiceModel.Channels.Message ReadMessage(System.ArraySegment<System.Byte> buffer, System.ServiceModel.Channels.BufferManager bufferManager, string contentType);
    public System.ServiceModel.Channels.Message ReadMessage(System.IO.Stream stream, int maxSizeOfHeaders) { return default(System.ServiceModel.Channels.Message); }
    public abstract System.ServiceModel.Channels.Message ReadMessage(System.IO.Stream stream, int maxSizeOfHeaders, string contentType);
    public override string ToString() { return default(string); }
    public System.ArraySegment<System.Byte> WriteMessage(System.ServiceModel.Channels.Message message, int maxMessageSize, System.ServiceModel.Channels.BufferManager bufferManager) { return default(System.ArraySegment<System.Byte>); }
    public abstract System.ArraySegment<System.Byte> WriteMessage(System.ServiceModel.Channels.Message message, int maxMessageSize, System.ServiceModel.Channels.BufferManager bufferManager, int messageOffset);
    public abstract void WriteMessage(System.ServiceModel.Channels.Message message, System.IO.Stream stream);
  }
  public abstract partial class MessageEncoderFactory {
    protected MessageEncoderFactory() { }
    public abstract System.ServiceModel.Channels.MessageEncoder Encoder { get; }
    public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; }
    [System.MonoTODOAttribute("Not sure how it is used; it just returns Encoder so far")]
    public virtual System.ServiceModel.Channels.MessageEncoder CreateSessionEncoder() { return default(System.ServiceModel.Channels.MessageEncoder); }
  }
  public abstract partial class MessageEncodingBindingElement : System.ServiceModel.Channels.BindingElement {
    public MessageEncodingBindingElement() { }
    [System.MonoTODOAttribute]
    public MessageEncodingBindingElement(System.ServiceModel.Channels.MessageEncodingBindingElement source) { }
    public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; set; }
    public abstract System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory();
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext ctx) { return default(T); }
    [System.MonoTODOAttribute]
    protected virtual void OnImportPolicy(System.Xml.XmlElement assertion, System.ServiceModel.Channels.MessageVersion messageVersion, System.ServiceModel.Description.MetadataImporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public partial class MessageEncodingBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension, System.ServiceModel.Description.IWsdlImportExtension {
    public MessageEncodingBindingElementImporter() { }
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
    void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public abstract partial class MessageFault {
    protected MessageFault() { }
    [System.MonoTODOAttribute("is this true?")]
    public virtual string Actor { get { return default(string); } }
    public abstract System.ServiceModel.FaultCode Code { get; }
    public abstract bool HasDetail { get; }
    [System.MonoTODOAttribute("is this true?")]
    public virtual string Node { get { return default(string); } }
    public abstract System.ServiceModel.FaultReason Reason { get; }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.Channels.Message message, int maxBufferSize) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail, System.Runtime.Serialization.XmlObjectSerializer formatter) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail, System.Runtime.Serialization.XmlObjectSerializer formatter, string actor) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail, System.Runtime.Serialization.XmlObjectSerializer formatter, string actor, string node) { return default(System.ServiceModel.Channels.MessageFault); }
    public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, string reason) { return default(System.ServiceModel.Channels.MessageFault); }
    public T GetDetail<T>() { return default(T); }
    public T GetDetail<T>(System.Runtime.Serialization.XmlObjectSerializer formatter) { return default(T); }
    public System.Xml.XmlDictionaryReader GetReaderAtDetailContents() { return default(System.Xml.XmlDictionaryReader); }
    protected virtual System.Xml.XmlDictionaryReader OnGetReaderAtDetailContents() { return default(System.Xml.XmlDictionaryReader); }
    protected virtual void OnWriteDetail(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
    protected abstract void OnWriteDetailContents(System.Xml.XmlDictionaryWriter writer);
    protected virtual void OnWriteStartDetail(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
    public void WriteTo(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
    public void WriteTo(System.Xml.XmlWriter writer, System.ServiceModel.EnvelopeVersion version) { }
  }
  public abstract partial class MessageHeader : System.ServiceModel.Channels.MessageHeaderInfo {
    protected MessageHeader() { }
    public override string Actor { get { return default(string); } }
    public override bool IsReferenceParameter { get { return default(bool); } }
    public override bool MustUnderstand { get { return default(bool); } }
    public override bool Relay { get { return default(bool); } }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool must_understand) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool must_understand, string actor) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool must_understand, string actor, bool relay) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer formatter) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer formatter, bool must_understand) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer formatter, bool must_understand, string actor) { return default(System.ServiceModel.Channels.MessageHeader); }
    public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer formatter, bool must_understand, string actor, bool relay) { return default(System.ServiceModel.Channels.MessageHeader); }
    public virtual bool IsMessageVersionSupported(System.ServiceModel.Channels.MessageVersion version) { return default(bool); }
    protected abstract void OnWriteHeaderContents(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion version);
    protected virtual void OnWriteStartHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion version) { }
    public override string ToString() { return default(string); }
    public void WriteHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion version) { }
    public void WriteHeader(System.Xml.XmlWriter writer, System.ServiceModel.Channels.MessageVersion version) { }
    protected void WriteHeaderAttributes(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion version) { }
    public void WriteHeaderContents(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion version) { }
    public void WriteStartHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion version) { }
  }
  public abstract partial class MessageHeaderInfo {
    protected MessageHeaderInfo() { }
    public abstract string Actor { get; }
    public abstract bool IsReferenceParameter { get; }
    public abstract bool MustUnderstand { get; }
    public abstract string Name { get; }
    public abstract string Namespace { get; }
    public abstract bool Relay { get; }
  }
  public sealed partial class MessageHeaders : System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.MessageHeaderInfo>, System.Collections.IEnumerable {
    public MessageHeaders(System.ServiceModel.Channels.MessageHeaders headers) { }
    public MessageHeaders(System.ServiceModel.Channels.MessageVersion version) { }
    public MessageHeaders(System.ServiceModel.Channels.MessageVersion version, int capacity) { }
    public string Action { get { return default(string); } set { } }
    public int Count { get { return default(int); } }
    public System.ServiceModel.EndpointAddress FaultTo { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.EndpointAddress From { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.MessageHeaderInfo this[int index] { get { return default(System.ServiceModel.Channels.MessageHeaderInfo); } }
    public System.Xml.UniqueId MessageId { get { return default(System.Xml.UniqueId); } set { } }
    public System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public System.Xml.UniqueId RelatesTo { get { return default(System.Xml.UniqueId); } set { } }
    public System.ServiceModel.EndpointAddress ReplyTo { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.Uri To { get { return default(System.Uri); } set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.Channels.UnderstoodHeaders UnderstoodHeaders { get { return default(System.ServiceModel.Channels.UnderstoodHeaders); } }
    public void Add(System.ServiceModel.Channels.MessageHeader header) { }
    public void Clear() { }
    public void CopyHeaderFrom(System.ServiceModel.Channels.Message m, int index) { }
    public void CopyHeaderFrom(System.ServiceModel.Channels.MessageHeaders headers, int index) { }
    public void CopyHeadersFrom(System.ServiceModel.Channels.Message m) { }
    public void CopyHeadersFrom(System.ServiceModel.Channels.MessageHeaders headers) { }
    public void CopyTo(System.ServiceModel.Channels.MessageHeaderInfo[] dst, int index) { }
    public int FindHeader(string name, string ns) { return default(int); }
    public int FindHeader(string name, string ns, params System.String[] actors) { return default(int); }
    public System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo>); }
    public T GetHeader<T>(int index) { return default(T); }
    public T GetHeader<T>(int index, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    public T GetHeader<T>(string name, string ns) { return default(T); }
    public T GetHeader<T>(string name, string ns, System.Runtime.Serialization.XmlObjectSerializer serializer) { return default(T); }
    public T GetHeader<T>(string name, string ns, params System.String[] actors) { return default(T); }
    public System.Xml.XmlDictionaryReader GetReaderAtHeader(int index) { return default(System.Xml.XmlDictionaryReader); }
    public bool HaveMandatoryHeadersBeenUnderstood() { return default(bool); }
    public bool HaveMandatoryHeadersBeenUnderstood(params System.String[] actors) { return default(bool); }
    public void Insert(int index, System.ServiceModel.Channels.MessageHeader header) { }
    public void RemoveAll(string name, string ns) { }
    public void RemoveAt(int index) { }
    public void SetAction(System.Xml.XmlDictionaryString action) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void WriteHeader(int index, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteHeader(int index, System.Xml.XmlWriter writer) { }
    public void WriteHeaderContents(int index, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteHeaderContents(int index, System.Xml.XmlWriter writer) { }
    public void WriteStartHeader(int index, System.Xml.XmlDictionaryWriter writer) { }
    public void WriteStartHeader(int index, System.Xml.XmlWriter writer) { }
  }
  public sealed partial class MessageProperties : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.Generic.IDictionary<System.String, System.Object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String, System.Object>>, System.Collections.IEnumerable, System.IDisposable {
    public MessageProperties() { }
    public MessageProperties(System.ServiceModel.Channels.MessageProperties properties) { }
    public bool AllowOutputBatching { get { return default(bool); } set { } }
    public int Count { get { return default(int); } }
    public System.ServiceModel.Channels.MessageEncoder Encoder { get { return default(System.ServiceModel.Channels.MessageEncoder); } set { } }
    public bool IsFixedSize { get { return default(bool); } }
    public bool IsReadOnly { get { return default(bool); } }
    public object this[string name] { get { return default(object); } set { } }
    public System.Collections.Generic.ICollection<System.String> Keys { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.ServiceModel.Security.SecurityMessageProperty Security { get { return default(System.ServiceModel.Security.SecurityMessageProperty); } set { } }
    public System.Collections.Generic.ICollection<System.Object> Values { get { return default(System.Collections.Generic.ICollection<System.Object>); } }
    public System.Uri Via { get { return default(System.Uri); } set { } }
    public void Add(string name, object property) { }
    public void Clear() { }
    public bool ContainsKey(string name) { return default(bool); }
    public void CopyProperties(System.ServiceModel.Channels.MessageProperties properties) { }
    public void Dispose() { }
    public bool Remove(string name) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Add(System.Collections.Generic.KeyValuePair<System.String, System.Object> pair) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Contains(System.Collections.Generic.KeyValuePair<System.String, System.Object> pair) { return default(bool); }
    void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.CopyTo(System.Collections.Generic.KeyValuePair<System.String, System.Object>[] array, int index) { }
    bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Remove(System.Collections.Generic.KeyValuePair<System.String, System.Object> pair) { return default(bool); }
    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object>>.GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String, System.Object>>); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(string name, out object value) { value = default(object); return default(bool); }
  }
  public enum MessageState {
    Closed = 4,
    Copied = 3,
    Created = 0,
    Read = 1,
    Written = 2,
  }
  public sealed partial class MessageVersion {
    internal MessageVersion() { }
    public System.ServiceModel.Channels.AddressingVersion Addressing { get { return default(System.ServiceModel.Channels.AddressingVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Default { get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public System.ServiceModel.EnvelopeVersion Envelope { get { return default(System.ServiceModel.EnvelopeVersion); } }
    public static System.ServiceModel.Channels.MessageVersion None { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap11WSAddressing10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap11WSAddressingAugust2004 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap12WSAddressing10 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion Soap12WSAddressingAugust2004 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.MessageVersion); } }
    public static System.ServiceModel.Channels.MessageVersion CreateVersion(System.ServiceModel.EnvelopeVersion envelope_version) { return default(System.ServiceModel.Channels.MessageVersion); }
    public static System.ServiceModel.Channels.MessageVersion CreateVersion(System.ServiceModel.EnvelopeVersion envelope_version, System.ServiceModel.Channels.AddressingVersion addressing_version) { return default(System.ServiceModel.Channels.MessageVersion); }
    public override bool Equals(object value) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override string ToString() { return default(string); }
  }
  public abstract partial class MsmqBindingElementBase : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Channels.ITransactedBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    internal MsmqBindingElementBase() { }
    public System.Uri CustomDeadLetterQueue { get { return default(System.Uri); } set { } }
    public System.ServiceModel.DeadLetterQueue DeadLetterQueue { get { return default(System.ServiceModel.DeadLetterQueue); } set { } }
    public bool Durable { get { return default(bool); } set { } }
    public bool ExactlyOnce { get { return default(bool); } set { } }
    public int MaxRetryCycles { get { return default(int); } set { } }
    public System.ServiceModel.MsmqTransportSecurity MsmqTransportSecurity { get { return default(System.ServiceModel.MsmqTransportSecurity); } }
    public System.ServiceModel.ReceiveErrorHandling ReceiveErrorHandling { get { return default(System.ServiceModel.ReceiveErrorHandling); } set { } }
    public int ReceiveRetryCount { get { return default(int); } set { } }
    public System.TimeSpan RetryCycleDelay { get { return default(System.TimeSpan); } set { } }
    public System.TimeSpan TimeToLive { get { return default(System.TimeSpan); } set { } }
    public bool TransactedReceiveEnabled { get { return default(bool); } }
    public bool UseMsmqTracing { get { return default(bool); } set { } }
    public bool UseSourceJournal { get { return default(bool); } set { } }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext endpointContext) { }
  }
  public sealed partial class MsmqMessageProperty {
    internal MsmqMessageProperty() { }
    public const string Name = "MsmqMessageProperty";
    public int AbortCount { get { return default(int); } }
    public System.Nullable<System.ServiceModel.Channels.DeliveryFailure> DeliveryFailure { get { return default(System.Nullable<System.ServiceModel.Channels.DeliveryFailure>); } }
    public System.Nullable<System.ServiceModel.Channels.DeliveryStatus> DeliveryStatus { get { return default(System.Nullable<System.ServiceModel.Channels.DeliveryStatus>); } }
    public int MoveCount { get { return default(int); } }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.MsmqMessageProperty Get(System.ServiceModel.Channels.Message message) { return default(System.ServiceModel.Channels.MsmqMessageProperty); }
  }
  public sealed partial class MsmqTransportBindingElement : System.ServiceModel.Channels.MsmqBindingElementBase {
    public MsmqTransportBindingElement() { }
    public int MaxPoolSize { get { return default(int); } set { } }
    public System.ServiceModel.QueueTransferProtocol QueueTransferProtocol { get { return default(System.ServiceModel.QueueTransferProtocol); } set { } }
    public override string Scheme { get { return default(string); } }
    [System.MonoLimitationAttribute("ActiveDirectory is windows-only solution")]
    public bool UseActiveDirectory { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class MtomMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public MtomMessageEncodingBindingElement() { }
    public MtomMessageEncodingBindingElement(System.ServiceModel.Channels.MessageVersion version, System.Text.Encoding encoding) { }
    public int MaxBufferSize { get { return default(int); } set { } }
    public int MaxReadPoolSize { get { return default(int); } set { } }
    public int MaxWritePoolSize { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } set { } }
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    public void ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.MonoTODOAttribute]
    protected override void OnImportPolicy(System.Xml.XmlElement assertion, System.ServiceModel.Channels.MessageVersion messageVersion, System.ServiceModel.Description.MetadataImporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public sealed partial class NamedPipeConnectionPoolSettings {
    internal NamedPipeConnectionPoolSettings() { }
    [System.MonoTODOAttribute]
    public string GroupName { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    [System.MonoTODOAttribute]
    public int MaxOutboundConnectionsPerEndpoint { get { return default(int); } set { } }
  }
  public partial class NamedPipeTransportBindingElement : System.ServiceModel.Channels.ConnectionOrientedTransportBindingElement {
    public NamedPipeTransportBindingElement() { }
    protected NamedPipeTransportBindingElement(System.ServiceModel.Channels.NamedPipeTransportBindingElement other) { }
    public System.ServiceModel.Channels.NamedPipeConnectionPoolSettings ConnectionPoolSettings { get { return default(System.ServiceModel.Channels.NamedPipeConnectionPoolSettings); } }
    public override string Scheme { get { return default(string); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public sealed partial class OneWayBindingElement : System.ServiceModel.Channels.BindingElement {
    public OneWayBindingElement() { }
    public System.ServiceModel.Channels.ChannelPoolSettings ChannelPoolSettings { get { return default(System.ServiceModel.Channels.ChannelPoolSettings); } }
    [System.MonoTODOAttribute("It generates just pass-thru factory")]
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.MonoTODOAttribute("It generates just pass-thru listener")]
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public sealed partial class OneWayBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public OneWayBindingElementImporter() { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public partial class PeerCustomResolverBindingElement : System.ServiceModel.Channels.PeerResolverBindingElement {
    public PeerCustomResolverBindingElement() { }
    public PeerCustomResolverBindingElement(System.ServiceModel.Channels.BindingContext context, System.ServiceModel.PeerResolvers.PeerCustomResolverSettings settings) { }
    public PeerCustomResolverBindingElement(System.ServiceModel.Channels.PeerCustomResolverBindingElement other) { }
    public PeerCustomResolverBindingElement(System.ServiceModel.PeerResolvers.PeerCustomResolverSettings settings) { }
    public System.ServiceModel.EndpointAddress Address { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.Binding Binding { get { return default(System.ServiceModel.Channels.Binding); } set { } }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.PeerResolvers.PeerReferralPolicy ReferralPolicy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.PeerResolvers.PeerReferralPolicy); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.PeerResolver CreatePeerResolver() { return default(System.ServiceModel.PeerResolver); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public abstract partial class PeerResolverBindingElement : System.ServiceModel.Channels.BindingElement {
    protected PeerResolverBindingElement() { }
    protected PeerResolverBindingElement(System.ServiceModel.Channels.PeerResolverBindingElement other) { }
    public abstract System.ServiceModel.PeerResolvers.PeerReferralPolicy ReferralPolicy { get; set; }
    public abstract System.ServiceModel.PeerResolver CreatePeerResolver();
  }
  [System.MonoTODOAttribute]
  public sealed partial class PeerTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public PeerTransportBindingElement() { }
    public System.Net.IPAddress ListenIPAddress { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.IPAddress); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override long MaxReceivedMessageSize { get { return default(long); } set { } }
    public int Port { get { return default(int); } set { } }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.PeerSecuritySettings Security { get { return default(System.ServiceModel.PeerSecuritySettings); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext contxt) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  [System.MonoTODOAttribute("We aren't actually going to implement this windows-only protocol")]
  public partial class PnrpPeerResolverBindingElement : System.ServiceModel.Channels.PeerResolverBindingElement {
    public PnrpPeerResolverBindingElement() { }
    public override System.ServiceModel.PeerResolvers.PeerReferralPolicy ReferralPolicy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.PeerResolvers.PeerReferralPolicy); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.PeerResolver CreatePeerResolver() { return default(System.ServiceModel.PeerResolver); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public sealed partial class PrivacyNoticeBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public PrivacyNoticeBindingElement() { }
    public PrivacyNoticeBindingElement(System.ServiceModel.Channels.PrivacyNoticeBindingElement elementToBeCloned) { }
    [System.MonoTODOAttribute]
    public System.Uri Url { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int Version { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public partial class PrivacyNoticeBindingElementImporter {
    public PrivacyNoticeBindingElementImporter() { }
  }
  public sealed partial class ReliableSessionBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public ReliableSessionBindingElement() { }
    public ReliableSessionBindingElement(bool ordered) { }
    [System.MonoTODOAttribute]
    public System.TimeSpan AcknowledgementInterval { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool FlowControlEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.TimeSpan InactivityTimeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int MaxPendingChannels { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int MaxRetryCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int MaxTransferWindowSize { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool Ordered { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.ReliableMessagingVersion ReliableMessagingVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.ReliableMessagingVersion); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    [System.MonoTODOAttribute]
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public sealed partial class ReliableSessionBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public ReliableSessionBindingElementImporter() { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public sealed partial class RemoteEndpointMessageProperty {
    public RemoteEndpointMessageProperty(string address, int port) { }
    public string Address { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static string Name { get { return default(string); } }
    public int Port { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } }
  }
  public abstract partial class RequestContext : System.IDisposable {
    protected RequestContext() { }
    public abstract System.ServiceModel.Channels.Message RequestMessage { get; }
    public abstract void Abort();
    public abstract System.IAsyncResult BeginReply(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
    public abstract System.IAsyncResult BeginReply(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
    public abstract void Close();
    public abstract void Close(System.TimeSpan timeout);
    protected virtual void Dispose(bool disposing) { }
    public abstract void EndReply(System.IAsyncResult result);
    public abstract void Reply(System.ServiceModel.Channels.Message message);
    public abstract void Reply(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
    void System.IDisposable.Dispose() { }
  }
  public abstract partial class SecurityBindingElement : System.ServiceModel.Channels.BindingElement {
    internal SecurityBindingElement() { }
    public System.ServiceModel.Security.SecurityAlgorithmSuite DefaultAlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public System.ServiceModel.Security.Tokens.SupportingTokenParameters EndpointSupportingTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SupportingTokenParameters); } }
    public bool IncludeTimestamp { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Security.SecurityKeyEntropyMode KeyEntropyMode { get { return default(System.ServiceModel.Security.SecurityKeyEntropyMode); } set { } }
    public System.ServiceModel.Channels.LocalClientSecuritySettings LocalClientSettings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.LocalClientSecuritySettings); } }
    public System.ServiceModel.Channels.LocalServiceSecuritySettings LocalServiceSettings { get { return default(System.ServiceModel.Channels.LocalServiceSecuritySettings); } }
    public System.ServiceModel.MessageSecurityVersion MessageSecurityVersion { get { return default(System.ServiceModel.MessageSecurityVersion); } set { } }
    public System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Security.Tokens.SupportingTokenParameters> OperationSupportingTokenParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Security.Tokens.SupportingTokenParameters>); } }
    public System.ServiceModel.Security.Tokens.SupportingTokenParameters OptionalEndpointSupportingTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SupportingTokenParameters); } }
    public System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Security.Tokens.SupportingTokenParameters> OptionalOperationSupportingTokenParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.ServiceModel.Security.Tokens.SupportingTokenParameters>); } }
    public System.ServiceModel.Channels.SecurityHeaderLayout SecurityHeaderLayout { get { return default(System.ServiceModel.Channels.SecurityHeaderLayout); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    protected abstract System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context);
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    protected abstract System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(System.ServiceModel.Channels.BindingContext context) where TChannel : class, System.ServiceModel.Channels.IChannel;
    [System.MonoTODOAttribute("Implement for TransportSecurityBindingElement")]
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    [System.MonoTODOAttribute("Implement for TransportSecurityBindingElement")]
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateAnonymousForCertificateBindingElement() { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateCertificateOverTransportBindingElement() { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateCertificateOverTransportBindingElement(System.ServiceModel.MessageSecurityVersion version) { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.AsymmetricSecurityBindingElement CreateCertificateSignatureBindingElement() { return default(System.ServiceModel.Channels.AsymmetricSecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateIssuedTokenBindingElement(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedTokenParameters) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateIssuedTokenForCertificateBindingElement(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedTokenParameters) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateIssuedTokenForSslBindingElement(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedTokenParameters) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateIssuedTokenForSslBindingElement(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedTokenParameters, bool requireCancellation) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateIssuedTokenOverTransportBindingElement(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters issuedTokenParameters) { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateKerberosBindingElement() { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateKerberosOverTransportBindingElement() { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateMutualCertificateBindingElement() { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateMutualCertificateBindingElement(System.ServiceModel.MessageSecurityVersion version) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    [System.MonoTODOAttribute("Does not support allowSerializedSigningTokenOnReply.")]
    public static System.ServiceModel.Channels.SecurityBindingElement CreateMutualCertificateBindingElement(System.ServiceModel.MessageSecurityVersion version, bool allowSerializedSigningTokenOnReply) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.AsymmetricSecurityBindingElement CreateMutualCertificateDuplexBindingElement() { return default(System.ServiceModel.Channels.AsymmetricSecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.AsymmetricSecurityBindingElement CreateMutualCertificateDuplexBindingElement(System.ServiceModel.MessageSecurityVersion version) { return default(System.ServiceModel.Channels.AsymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateSecureConversationBindingElement(System.ServiceModel.Channels.SecurityBindingElement binding) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateSecureConversationBindingElement(System.ServiceModel.Channels.SecurityBindingElement binding, bool requireCancellation) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.SecurityBindingElement CreateSecureConversationBindingElement(System.ServiceModel.Channels.SecurityBindingElement binding, bool requireCancellation, System.ServiceModel.Security.ChannelProtectionRequirements protectionRequirements) { return default(System.ServiceModel.Channels.SecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateSslNegotiationBindingElement(bool requireClientCertificate) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateSslNegotiationBindingElement(bool requireClientCertificate, bool requireCancellation) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateSspiNegotiationBindingElement() { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateSspiNegotiationBindingElement(bool requireCancellation) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateSspiNegotiationOverTransportBindingElement() { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateSspiNegotiationOverTransportBindingElement(bool requireCancellation) { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateUserNameForCertificateBindingElement() { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateUserNameForSslBindingElement() { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    public static System.ServiceModel.Channels.SymmetricSecurityBindingElement CreateUserNameForSslBindingElement(bool requireCancellation) { return default(System.ServiceModel.Channels.SymmetricSecurityBindingElement); }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateUserNameOverTransportBindingElement() { return default(System.ServiceModel.Channels.TransportSecurityBindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    protected static void SetIssuerBindingContextIfRequired(System.ServiceModel.Security.Tokens.SecurityTokenParameters parameters, System.ServiceModel.Channels.BindingContext issuerBindingContext) { }
    public virtual void SetKeyDerivation(bool requireDerivedKeys) { }
    public override string ToString() { return default(string); }
  }
  public partial class SecurityBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public SecurityBindingElementImporter() { }
    [System.MonoTODOAttribute]
    public int MaxPolicyRedirections { get { return default(int); } }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public enum SecurityHeaderLayout {
    Lax = 1,
    LaxTimestampFirst = 2,
    LaxTimestampLast = 3,
    Strict = 0,
  }
  [System.MonoTODOAttribute]
  public partial class SslStreamSecurityBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Channels.ITransportTokenAssertionProvider, System.ServiceModel.Description.IPolicyExportExtension {
    public SslStreamSecurityBindingElement() { }
    public System.ServiceModel.Security.IdentityVerifier IdentityVerifier { get { return default(System.ServiceModel.Security.IdentityVerifier); } set { } }
    public bool RequireClientCertificate { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    [System.MonoTODOAttribute]
    public System.ServiceModel.Channels.StreamUpgradeProvider BuildClientStreamUpgradeProvider(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.StreamUpgradeProvider); }
    [System.MonoTODOAttribute]
    public System.ServiceModel.Channels.StreamUpgradeProvider BuildServerStreamUpgradeProvider(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.StreamUpgradeProvider); }
    [System.MonoTODOAttribute]
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.MonoTODOAttribute]
    public System.Xml.XmlElement GetTransportTokenAssertion() { return default(System.Xml.XmlElement); }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public partial class StandardBindingImporter : System.ServiceModel.Description.IWsdlImportExtension {
    public StandardBindingImporter() { }
    public void BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy) { }
    public void ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext contractContext) { }
    public void ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public abstract partial class StreamSecurityUpgradeAcceptor : System.ServiceModel.Channels.StreamUpgradeAcceptor {
    protected StreamSecurityUpgradeAcceptor() { }
    public abstract System.ServiceModel.Security.SecurityMessageProperty GetRemoteSecurity();
  }
  public abstract partial class StreamSecurityUpgradeInitiator : System.ServiceModel.Channels.StreamUpgradeInitiator {
    protected StreamSecurityUpgradeInitiator() { }
    public abstract System.ServiceModel.Security.SecurityMessageProperty GetRemoteSecurity();
  }
  public abstract partial class StreamSecurityUpgradeProvider : System.ServiceModel.Channels.StreamUpgradeProvider {
    protected StreamSecurityUpgradeProvider() { }
    protected StreamSecurityUpgradeProvider(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    public abstract System.ServiceModel.EndpointIdentity Identity { get; }
  }
  public abstract partial class StreamUpgradeAcceptor {
    protected StreamUpgradeAcceptor() { }
    public virtual System.IO.Stream AcceptUpgrade(System.IO.Stream stream) { return default(System.IO.Stream); }
    public abstract System.IAsyncResult BeginAcceptUpgrade(System.IO.Stream stream, System.AsyncCallback callback, object state);
    public abstract bool CanUpgrade(string contentType);
    public abstract System.IO.Stream EndAcceptUpgrade(System.IAsyncResult result);
  }
  public abstract partial class StreamUpgradeBindingElement : System.ServiceModel.Channels.BindingElement {
    protected StreamUpgradeBindingElement() { }
    protected StreamUpgradeBindingElement(System.ServiceModel.Channels.StreamUpgradeBindingElement other) { }
    public abstract System.ServiceModel.Channels.StreamUpgradeProvider BuildClientStreamUpgradeProvider(System.ServiceModel.Channels.BindingContext context);
    public abstract System.ServiceModel.Channels.StreamUpgradeProvider BuildServerStreamUpgradeProvider(System.ServiceModel.Channels.BindingContext context);
  }
  public abstract partial class StreamUpgradeInitiator {
    protected StreamUpgradeInitiator() { }
    public abstract System.IAsyncResult BeginInitiateUpgrade(System.IO.Stream stream, System.AsyncCallback callback, object state);
    public abstract System.IO.Stream EndInitiateUpgrade(System.IAsyncResult result);
    public abstract string GetNextUpgrade();
    public abstract System.IO.Stream InitiateUpgrade(System.IO.Stream stream);
  }
  public abstract partial class StreamUpgradeProvider : System.ServiceModel.Channels.CommunicationObject {
    protected StreamUpgradeProvider() { }
    protected StreamUpgradeProvider(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    protected internal override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public abstract System.ServiceModel.Channels.StreamUpgradeAcceptor CreateUpgradeAcceptor();
    public abstract System.ServiceModel.Channels.StreamUpgradeInitiator CreateUpgradeInitiator(System.ServiceModel.EndpointAddress remoteAddress, System.Uri via);
  }
  public enum SupportedAddressingMode {
    Anonymous = 0,
    Mixed = 2,
    NonAnonymous = 1,
  }
  public sealed partial class SymmetricSecurityBindingElement : System.ServiceModel.Channels.SecurityBindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public SymmetricSecurityBindingElement() { }
    public SymmetricSecurityBindingElement(System.ServiceModel.Security.Tokens.SecurityTokenParameters protectionTokenParameters) { }
    [System.MonoTODOAttribute]
    public System.ServiceModel.Security.MessageProtectionOrder MessageProtectionOrder { get { return default(System.ServiceModel.Security.MessageProtectionOrder); } set { } }
    public System.ServiceModel.Security.Tokens.SecurityTokenParameters ProtectionTokenParameters { get { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); } set { } }
    [System.MonoTODOAttribute]
    public bool RequireSignatureConfirmation { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.MonoTODOAttribute]
    protected override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    public override void SetKeyDerivation(bool requireDerivedKeys) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext policyContext) { }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public sealed partial class TcpConnectionPoolSettings {
    internal TcpConnectionPoolSettings() { }
    [System.MonoTODOAttribute]
    public string GroupName { get { return default(string); } set { } }
    [System.MonoTODOAttribute]
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    [System.MonoTODOAttribute]
    public System.TimeSpan LeaseTimeout { get { return default(System.TimeSpan); } set { } }
    [System.MonoTODOAttribute]
    public int MaxOutboundConnectionsPerEndpoint { get { return default(int); } set { } }
  }
  public partial class TcpTransportBindingElement : System.ServiceModel.Channels.ConnectionOrientedTransportBindingElement {
    public TcpTransportBindingElement() { }
    protected TcpTransportBindingElement(System.ServiceModel.Channels.TcpTransportBindingElement other) { }
    public System.ServiceModel.Channels.TcpConnectionPoolSettings ConnectionPoolSettings { get { return default(System.ServiceModel.Channels.TcpConnectionPoolSettings); } }
    public int ListenBacklog { get { return default(int); } set { } }
    public bool PortSharingEnabled { get { return default(bool); } set { } }
    public override string Scheme { get { return default(string); } }
    public bool TeredoEnabled { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class TextMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension {
    public TextMessageEncodingBindingElement() { }
    public TextMessageEncodingBindingElement(System.ServiceModel.Channels.MessageVersion messageVersion, System.Text.Encoding writeEncoding) { }
    public int MaxReadPoolSize { get { return default(int); } set { } }
    public int MaxWritePoolSize { get { return default(int); } set { } }
    public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { return default(System.Xml.XmlDictionaryReaderQuotas); } }
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { return default(System.ServiceModel.Channels.MessageEncoderFactory); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.MonoTODOAttribute]
    protected override void OnImportPolicy(System.Xml.XmlElement assertion, System.ServiceModel.Channels.MessageVersion messageVersion, System.ServiceModel.Description.MetadataImporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public partial class TransactionFlowBindingElement : System.ServiceModel.Channels.BindingElement {
    [System.MonoTODOAttribute]
    public TransactionFlowBindingElement() { }
    public TransactionFlowBindingElement(System.ServiceModel.TransactionProtocol protocol) { }
    public System.ServiceModel.TransactionProtocol TransactionProtocol { get { return default(System.ServiceModel.TransactionProtocol); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    [System.MonoTODOAttribute]
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public sealed partial class TransactionFlowBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension {
    public TransactionFlowBindingElementImporter() { }
    [System.MonoTODOAttribute]
    public void ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
    [System.MonoTODOAttribute]
    public System.Xml.XmlElement GetAssertion(System.Xml.XmlDocument doc, System.ServiceModel.TransactionFlowOption option, string prefix, string name, string ns) { return default(System.Xml.XmlElement); }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyImportExtension.ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public enum TransferSession {
    None = 0,
    Ordered = 1,
    Unordered = 2,
  }
  public abstract partial class TransportBindingElement : System.ServiceModel.Channels.BindingElement {
    protected TransportBindingElement() { }
    protected TransportBindingElement(System.ServiceModel.Channels.TransportBindingElement other) { }
    public bool ManualAddressing { get { return default(bool); } set { } }
    public virtual long MaxBufferPoolSize { get { return default(long); } set { } }
    public virtual long MaxReceivedMessageSize { get { return default(long); } set { } }
    public abstract string Scheme { get; }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public partial class TransportBindingElementImporter : System.ServiceModel.Description.IPolicyImportExtension, System.ServiceModel.Description.IWsdlImportExtension {
    public TransportBindingElementImporter() { }
    public void BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy) { }
    public void ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext contractContext) { }
    public void ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
    public void ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public sealed partial class TransportSecurityBindingElement : System.ServiceModel.Channels.SecurityBindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public TransportSecurityBindingElement() { }
    [System.MonoTODOAttribute]
    protected override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.MonoTODOAttribute]
    protected override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListenerCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext policyContext) { }
  }
  public sealed partial class UnderstoodHeaders : System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.MessageHeaderInfo>, System.Collections.IEnumerable {
    internal UnderstoodHeaders() { }
    public void Add(System.ServiceModel.Channels.MessageHeaderInfo header) { }
    public bool Contains(System.ServiceModel.Channels.MessageHeaderInfo header) { return default(bool); }
    public System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo>); }
    public void Remove(System.ServiceModel.Channels.MessageHeaderInfo header) { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class UseManagedPresentationBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Description.IPolicyExportExtension {
    public UseManagedPresentationBindingElement() { }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    [System.MonoTODOAttribute]
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public partial class UseManagedPresentationBindingElementImporter {
    public UseManagedPresentationBindingElementImporter() { }
  }
  [System.MonoTODOAttribute]
  public partial class WindowsStreamSecurityBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Channels.ISecurityCapabilities, System.ServiceModel.Channels.ITransportTokenAssertionProvider, System.ServiceModel.Description.IPolicyExportExtension {
    public WindowsStreamSecurityBindingElement() { }
    public WindowsStreamSecurityBindingElement(System.ServiceModel.Channels.WindowsStreamSecurityBindingElement other) { }
    public System.Net.Security.ProtectionLevel ProtectionLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.Security.ProtectionLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    System.Net.Security.ProtectionLevel System.ServiceModel.Channels.ISecurityCapabilities.SupportedRequestProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } }
    [System.MonoTODOAttribute]
    System.Net.Security.ProtectionLevel System.ServiceModel.Channels.ISecurityCapabilities.SupportedResponseProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } }
    [System.MonoTODOAttribute]
    bool System.ServiceModel.Channels.ISecurityCapabilities.SupportsClientAuthentication { get { return default(bool); } }
    [System.MonoTODOAttribute]
    bool System.ServiceModel.Channels.ISecurityCapabilities.SupportsClientWindowsIdentity { get { return default(bool); } }
    [System.MonoTODOAttribute]
    bool System.ServiceModel.Channels.ISecurityCapabilities.SupportsServerAuthentication { get { return default(bool); } }
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
    public System.Xml.XmlElement GetTransportTokenAssertion() { return default(System.Xml.XmlElement); }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IPolicyExportExtension.ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context) { }
  }
  public partial class XmlSerializerImportOptions {
    public XmlSerializerImportOptions() { }
  }
}
namespace System.ServiceModel.ComIntegration {
  public partial class ComPlusListenerInitializationException {
    public ComPlusListenerInitializationException() { }
  }
  public partial class DllHostInitializer {
    public DllHostInitializer() { }
  }
  public partial interface IChannelCredentials {
  }
  public partial interface IMoniker {
  }
  public partial interface IServiceSurrogate {
  }
  public partial class ServiceMoniker {
    public ServiceMoniker() { }
  }
}
namespace System.ServiceModel.Configuration {
  public sealed partial class AddressHeaderCollectionElement : System.Configuration.ConfigurationElement {
    public AddressHeaderCollectionElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("headers", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Channels.AddressHeaderCollection Headers { get { return default(System.ServiceModel.Channels.AddressHeaderCollection); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
    [System.MonoTODOAttribute]
    protected override bool SerializeToXmlElement(System.Xml.XmlWriter writer, string elementName) { return default(bool); }
  }
  public sealed partial class AllowedAudienceUriElement : System.Configuration.ConfigurationElement {
    public AllowedAudienceUriElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("allowedAudienceUri", Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string AllowedAudienceUri { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.AllowedAudienceUriElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
  public sealed partial class AllowedAudienceUriElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.AllowedAudienceUriElement> {
    public AllowedAudienceUriElementCollection() { }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public enum AuthenticationMode {
    AnonymousForCertificate = 0,
    AnonymousForSslNegotiated = 1,
    CertificateOverTransport = 2,
    IssuedToken = 3,
    IssuedTokenForCertificate = 4,
    IssuedTokenForSslNegotiated = 5,
    IssuedTokenOverTransport = 6,
    Kerberos = 7,
    KerberosOverTransport = 8,
    MutualCertificate = 9,
    MutualCertificateDuplex = 10,
    MutualSslNegotiated = 11,
    SecureConversation = 12,
    SspiNegotiated = 13,
    SspiNegotiatedOverTransport = 17,
    UserNameForCertificate = 14,
    UserNameForSslNegotiated = 15,
    UserNameOverTransport = 16,
  }
  public sealed partial class AuthorizationPolicyTypeElement : System.Configuration.ConfigurationElement {
    public AuthorizationPolicyTypeElement() { }
    public AuthorizationPolicyTypeElement(string policyType) { }
    [System.Configuration.ConfigurationPropertyAttribute("policyType", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string PolicyType { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.AuthorizationPolicyTypeElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class AuthorizationPolicyTypeElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.AuthorizationPolicyTypeElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public AuthorizationPolicyTypeElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class BaseAddressElement : System.Configuration.ConfigurationElement {
    public BaseAddressElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("baseAddress", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string BaseAddress { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.BaseAddressElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
  public sealed partial class BaseAddressElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.BaseAddressElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public BaseAddressElementCollection() { }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class BaseAddressPrefixFilterElement : System.Configuration.ConfigurationElement {
    public BaseAddressPrefixFilterElement() { }
    public BaseAddressPrefixFilterElement(System.Uri prefix) { }
    [System.Configuration.ConfigurationPropertyAttribute("prefix", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    public System.Uri Prefix { get { return default(System.Uri); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.BaseAddressPrefixFilterElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
  public sealed partial class BaseAddressPrefixFilterElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.BaseAddressPrefixFilterElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public BaseAddressPrefixFilterElementCollection() { }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public partial class BasicHttpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.BasicHttpBinding, System.ServiceModel.Configuration.BasicHttpBindingElement> {
    public BasicHttpBindingCollectionElement() { }
  }
  public partial class BasicHttpBindingElement : System.ServiceModel.Configuration.StandardBindingElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public BasicHttpBindingElement() { }
    public BasicHttpBindingElement(string name) { }
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
    [System.Configuration.ConfigurationPropertyAttribute("messageEncoding", DefaultValue="Text", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.WSMessageEncoding MessageEncoding { get { return default(System.ServiceModel.WSMessageEncoding); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("proxyAddress", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.BasicHttpSecurityElement Security { get { return default(System.ServiceModel.Configuration.BasicHttpSecurityElement); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("textEncoding", DefaultValue="utf-8", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue="Buffered", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useDefaultWebProxy", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.Binding binding) { }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  public sealed partial class BasicHttpMessageSecurityElement : System.Configuration.ConfigurationElement {
    public BasicHttpMessageSecurityElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.SecurityAlgorithmSuiteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("algorithmSuite", DefaultValue="Default", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("clientCredentialType", DefaultValue="UserName", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.BasicHttpMessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.BasicHttpMessageCredentialType); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class BasicHttpSecurityElement : System.Configuration.ConfigurationElement {
    public BasicHttpSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("message", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.BasicHttpMessageSecurityElement Message { get { return default(System.ServiceModel.Configuration.BasicHttpMessageSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("mode", DefaultValue="None", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.BasicHttpSecurityMode Mode { get { return default(System.ServiceModel.BasicHttpSecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transport", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.HttpTransportSecurityElement Transport { get { return default(System.ServiceModel.Configuration.HttpTransportSecurityElement); } }
  }
  public abstract partial class BehaviorExtensionElement : System.ServiceModel.Configuration.ServiceModelExtensionElement {
    protected BehaviorExtensionElement() { }
    public abstract System.Type BehaviorType { get; }
    protected internal abstract object CreateBehavior();
  }
  public partial class BehaviorsSection : System.Configuration.ConfigurationSection {
    public BehaviorsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("endpointBehaviors", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.EndpointBehaviorElementCollection EndpointBehaviors { get { return default(System.ServiceModel.Configuration.EndpointBehaviorElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("serviceBehaviors", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ServiceBehaviorElementCollection ServiceBehaviors { get { return default(System.ServiceModel.Configuration.ServiceBehaviorElementCollection); } }
  }
  public sealed partial class BinaryMessageEncodingElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public BinaryMessageEncodingElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReadPoolSize", DefaultValue="64", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxReadPoolSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxSessionSize", DefaultValue="2048", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxSessionSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxWritePoolSize", DefaultValue="16", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxWritePoolSize { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement element) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement element) { }
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement element) { }
  }
  [System.MonoTODOAttribute]
  public abstract partial class BindingCollectionElement : System.Configuration.ConfigurationElement {
    protected BindingCollectionElement() { }
    public string BindingName { get { return default(string); } }
    public abstract System.Type BindingType { get; }
    public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Configuration.IBindingConfigurationElement> ConfiguredBindings { get; }
    public abstract bool ContainsKey(string name);
    protected internal abstract System.ServiceModel.Channels.Binding GetDefault();
    protected internal abstract bool TryAdd(string name, System.ServiceModel.Channels.Binding binding, System.Configuration.Configuration config);
  }
  public abstract partial class BindingElementExtensionElement : System.ServiceModel.Configuration.ServiceModelExtensionElement {
    protected BindingElementExtensionElement() { }
    public abstract System.Type BindingElementType { get; }
    public virtual void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    protected internal abstract System.ServiceModel.Channels.BindingElement CreateBindingElement();
    protected internal virtual void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  public sealed partial class BindingsSection : System.Configuration.ConfigurationSection {
    public BindingsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("basicHttpBinding", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.BasicHttpBindingCollectionElement BasicHttpBinding { get { return default(System.ServiceModel.Configuration.BasicHttpBindingCollectionElement); } }
    public System.Collections.Generic.List<System.ServiceModel.Configuration.BindingCollectionElement> BindingCollections { get { return default(System.Collections.Generic.List<System.ServiceModel.Configuration.BindingCollectionElement>); } }
    [System.Configuration.ConfigurationPropertyAttribute("customBinding", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.CustomBindingCollectionElement CustomBinding { get { return default(System.ServiceModel.Configuration.CustomBindingCollectionElement); } }
    public new System.ServiceModel.Configuration.BindingCollectionElement this[string name] { get { return default(System.ServiceModel.Configuration.BindingCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("msmqIntegrationBinding", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.MsmqIntegrationBindingCollectionElement MsmqIntegrationBinding { get { return default(System.ServiceModel.Configuration.MsmqIntegrationBindingCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("netMsmqBinding", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.NetMsmqBindingCollectionElement NetMsmqBinding { get { return default(System.ServiceModel.Configuration.NetMsmqBindingCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("netNamedPipeBinding", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.NetNamedPipeBindingCollectionElement NetNamedPipeBinding { get { return default(System.ServiceModel.Configuration.NetNamedPipeBindingCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("netPeerTcpBinding", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.NetPeerTcpBindingCollectionElement NetPeerTcpBinding { get { return default(System.ServiceModel.Configuration.NetPeerTcpBindingCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("netTcpBinding", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.NetTcpBindingCollectionElement NetTcpBinding { get { return default(System.ServiceModel.Configuration.NetTcpBindingCollectionElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("wsDualHttpBinding", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WSDualHttpBindingCollectionElement WSDualHttpBinding { get { return default(System.ServiceModel.Configuration.WSDualHttpBindingCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("wsFederationHttpBinding", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WSFederationHttpBindingCollectionElement WSFederationHttpBinding { get { return default(System.ServiceModel.Configuration.WSFederationHttpBindingCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("wsHttpBinding", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WSHttpBindingCollectionElement WSHttpBinding { get { return default(System.ServiceModel.Configuration.WSHttpBindingCollectionElement); } }
    public static System.ServiceModel.Configuration.BindingsSection GetSection(System.Configuration.Configuration config) { return default(System.ServiceModel.Configuration.BindingsSection); }
  }
  public sealed partial class CallbackDebugElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public CallbackDebugElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("includeExceptionDetailInFaults", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool IncludeExceptionDetailInFaults { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class CallbackTimeoutsElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public CallbackTimeoutsElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("transactionTimeout", DefaultValue="00:00:00", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.TimeSpan TransactionTimeout { get { return default(System.TimeSpan); } set { } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class CertificateElement : System.Configuration.ConfigurationElement {
    public CertificateElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("encodedValue", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string EncodedValue { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class CertificateReferenceElement : System.Configuration.ConfigurationElement {
    public CertificateReferenceElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("findValue", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string FindValue { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("isChainIncluded", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool IsChainIncluded { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("storeLocation", DefaultValue="LocalMachine", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreLocation StoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("storeName", DefaultValue="My", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreName StoreName { get { return default(System.Security.Cryptography.X509Certificates.StoreName); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("x509FindType", DefaultValue="FindBySubjectDistinguishedName", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.X509FindType X509FindType { get { return default(System.Security.Cryptography.X509Certificates.X509FindType); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class ChannelEndpointElement : System.Configuration.ConfigurationElement {
    public ChannelEndpointElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("address", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri Address { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("behaviorConfiguration", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string BehaviorConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("binding", Options=(System.Configuration.ConfigurationPropertyOptions)(2), IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Binding { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("bindingConfiguration", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string BindingConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("contract", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Contract { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("headers", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.AddressHeaderCollectionElement Headers { get { return default(System.ServiceModel.Configuration.AddressHeaderCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("identity", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IdentityElement Identity { get { return default(System.ServiceModel.Configuration.IdentityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(4), IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ChannelEndpointElement), AddItemName="endpoint", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  [System.MonoTODOAttribute]
  public sealed partial class ChannelEndpointElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.ChannelEndpointElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ChannelEndpointElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class ChannelPoolSettingsElement : System.Configuration.ConfigurationElement {
    public ChannelPoolSettingsElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("idleTimeout", DefaultValue="00:02:00", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("leaseTimeout", DefaultValue="00:10:00", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.TimeSpan LeaseTimeout { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxOutboundChannelsPerEndpoint", DefaultValue="10", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxOutboundChannelsPerEndpoint { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class ClaimTypeElement : System.Configuration.ConfigurationElement {
    public ClaimTypeElement() { }
    public ClaimTypeElement(string claimType, bool isOptional) { }
    [System.Configuration.ConfigurationPropertyAttribute("claimType", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string ClaimType { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("isOptional", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool IsOptional { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ClaimTypeElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class ClaimTypeElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.ClaimTypeElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ClaimTypeElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public partial class ClientCredentialsElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public ClientCredentialsElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("clientCertificate", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509InitiatorCertificateClientElement ClientCertificate { get { return default(System.ServiceModel.Configuration.X509InitiatorCertificateClientElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("httpDigest", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.MonoTODOAttribute]
    public System.ServiceModel.Configuration.HttpDigestClientElement HttpDigest { get { return default(System.ServiceModel.Configuration.HttpDigestClientElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("issuedToken", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IssuedTokenClientElement IssuedToken { get { return default(System.ServiceModel.Configuration.IssuedTokenClientElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("peer", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.PeerCredentialElement Peer { get { return default(System.ServiceModel.Configuration.PeerCredentialElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("serviceCertificate", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509RecipientCertificateClientElement ServiceCertificate { get { return default(System.ServiceModel.Configuration.X509RecipientCertificateClientElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("supportInteractive", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool SupportInteractive { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("type", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Type { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("windows", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WindowsClientElement Windows { get { return default(System.ServiceModel.Configuration.WindowsClientElement); } }
    protected internal void ApplyConfiguration(System.ServiceModel.Description.ClientCredentials cb) { }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class ClientSection : System.Configuration.ConfigurationSection {
    public ClientSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1), IsDefaultCollection=true)]
    public System.ServiceModel.Configuration.ChannelEndpointElementCollection Endpoints { get { return default(System.ServiceModel.Configuration.ChannelEndpointElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("metadata", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.MetadataElement Metadata { get { return default(System.ServiceModel.Configuration.MetadataElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override void InitializeDefault() { }
    protected override void PostDeserialize() { }
  }
  public sealed partial class ClientViaElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public ClientViaElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("viaUri", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri ViaUri { get { return default(System.Uri); } set { } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class ComContractElement : System.Configuration.ConfigurationElement {
    public ComContractElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("contract", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Contract { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("exposedMethods", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ComMethodElementCollection ExposedMethods { get { return default(System.ServiceModel.Configuration.ComMethodElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Name { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("namespace", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Namespace { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("persistableTypes", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ComPersistableTypeElementCollection PersistableTypes { get { return default(System.ServiceModel.Configuration.ComPersistableTypeElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("requiresSession", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool RequiresSession { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("userDefinedTypes", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ComUdtElementCollection UserDefinedTypes { get { return default(System.ServiceModel.Configuration.ComUdtElementCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ComContractElement), AddItemName="comContract", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  [System.MonoTODOAttribute]
  public sealed partial class ComContractElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.ComContractElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ComContractElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class ComContractsSection : System.Configuration.ConfigurationSection {
    public ComContractsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1), IsDefaultCollection=true)]
    public System.ServiceModel.Configuration.ComContractElementCollection ComContracts { get { return default(System.ServiceModel.Configuration.ComContractElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class ComMethodElement : System.Configuration.ConfigurationElement {
    public ComMethodElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("exposedMethod", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string ExposedMethod { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ComMethodElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  [System.MonoTODOAttribute]
  public sealed partial class ComMethodElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.ComMethodElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ComMethodElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  [System.MonoTODOAttribute]
  public partial class CommonBehaviorsSection : System.Configuration.ConfigurationSection {
    public CommonBehaviorsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("endpointBehaviors", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.CommonEndpointBehaviorElement EndpointBehaviors { get { return default(System.ServiceModel.Configuration.CommonEndpointBehaviorElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("serviceBehaviors", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.CommonServiceBehaviorElement ServiceBehaviors { get { return default(System.ServiceModel.Configuration.CommonServiceBehaviorElement); } }
  }
  [System.MonoTODOAttribute]
  public partial class CommonEndpointBehaviorElement : System.ServiceModel.Configuration.ServiceModelExtensionCollectionElement<System.ServiceModel.Configuration.BehaviorExtensionElement>, System.Collections.Generic.ICollection<System.ServiceModel.Configuration.BehaviorExtensionElement>, System.Collections.Generic.IEnumerable<System.ServiceModel.Configuration.BehaviorExtensionElement>, System.Collections.IEnumerable {
    public CommonEndpointBehaviorElement() { }
  }
  [System.MonoTODOAttribute]
  public partial class CommonServiceBehaviorElement : System.ServiceModel.Configuration.ServiceModelExtensionCollectionElement<System.ServiceModel.Configuration.BehaviorExtensionElement>, System.Collections.Generic.ICollection<System.ServiceModel.Configuration.BehaviorExtensionElement>, System.Collections.Generic.IEnumerable<System.ServiceModel.Configuration.BehaviorExtensionElement>, System.Collections.IEnumerable {
    public CommonServiceBehaviorElement() { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class ComPersistableTypeElement : System.Configuration.ConfigurationElement {
    public ComPersistableTypeElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("ID", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string ID { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ComPersistableTypeElement), AddItemName="type", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  [System.MonoTODOAttribute]
  public sealed partial class ComPersistableTypeElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.ComPersistableTypeElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ComPersistableTypeElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class CompositeDuplexElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public CompositeDuplexElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("clientBaseAddress", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=null)]
    public System.Uri ClientBaseAddress { get { return default(System.Uri); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class ComUdtElement : System.Configuration.ConfigurationElement {
    public ComUdtElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("typeDefID", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string TypeDefID { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("typeLibID", Options=(System.Configuration.ConfigurationPropertyOptions)(2), IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string TypeLibID { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("typeLibVersion", Options=(System.Configuration.ConfigurationPropertyOptions)(2), IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string TypeLibVersion { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ComUdtElement), AddItemName="userDefinedType", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  [System.MonoTODOAttribute]
  public sealed partial class ComUdtElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.ComUdtElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ComUdtElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public abstract partial class ConnectionOrientedTransportElement : System.ServiceModel.Configuration.TransportElement {
    internal ConnectionOrientedTransportElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("channelInitializationTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:00:05")]
    public System.TimeSpan ChannelInitializationTimeout { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("connectionBufferSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="8192")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int ConnectionBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="StrongWildcard")]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxOutputDelay", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:00:00.2")]
    public System.TimeSpan MaxOutputDelay { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingAccepts", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="1")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxPendingAccepts { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingConnections", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxPendingConnections { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Buffered")]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  public sealed partial class CustomBindingCollectionElement : System.ServiceModel.Configuration.BindingCollectionElement {
    public CustomBindingCollectionElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1), IsDefaultCollection=true)]
    public System.ServiceModel.Configuration.CustomBindingElementCollection Bindings { get { return default(System.ServiceModel.Configuration.CustomBindingElementCollection); } }
    public override System.Type BindingType { get { return default(System.Type); } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Configuration.IBindingConfigurationElement> ConfiguredBindings { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Configuration.IBindingConfigurationElement>); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public override bool ContainsKey(string name) { return default(bool); }
    protected internal override System.ServiceModel.Channels.Binding GetDefault() { return default(System.ServiceModel.Channels.Binding); }
    protected internal override bool TryAdd(string name, System.ServiceModel.Channels.Binding binding, System.Configuration.Configuration config) { return default(bool); }
  }
  public partial class CustomBindingElement : System.ServiceModel.Configuration.NamedServiceModelExtensionCollectionElement<System.ServiceModel.Configuration.BindingElementExtensionElement>, System.Collections.Generic.ICollection<System.ServiceModel.Configuration.BindingElementExtensionElement>, System.Collections.Generic.IEnumerable<System.ServiceModel.Configuration.BindingElementExtensionElement>, System.Collections.IEnumerable, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public CustomBindingElement() { }
    public CustomBindingElement(string name) { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("closeTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:01:00")]
    public System.TimeSpan CloseTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("openTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:01:00")]
    public System.TimeSpan OpenTimeout { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("receiveTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:10:00")]
    public System.TimeSpan ReceiveTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("sendTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:01:00")]
    public System.TimeSpan SendTimeout { get { return default(System.TimeSpan); } set { } }
    [System.MonoTODOAttribute("what to reject?")]
    public override void Add(System.ServiceModel.Configuration.BindingElementExtensionElement element) { }
    public void ApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
    [System.MonoTODOAttribute("what to reject?")]
    public override bool CanAdd(System.ServiceModel.Configuration.BindingElementExtensionElement element) { return default(bool); }
    protected void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.CustomBindingElement), AddItemName="binding", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  [System.MonoTODOAttribute]
  public sealed partial class CustomBindingElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.CustomBindingElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public CustomBindingElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class DataContractSerializerElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public DataContractSerializerElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("ignoreExtensionDataObject", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool IgnoreExtensionDataObject { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxItemsInObjectGraph", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxItemsInObjectGraph { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class DiagnosticSection : System.Configuration.ConfigurationSection {
    public DiagnosticSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("messageLogging", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.MessageLoggingElement MessageLogging { get { return default(System.ServiceModel.Configuration.MessageLoggingElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("performanceCounterEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool PerformanceCounterEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("performanceCounters", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Off")]
    public System.ServiceModel.Diagnostics.PerformanceCounterScope PerformanceCounters { get { return default(System.ServiceModel.Diagnostics.PerformanceCounterScope); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("wmiProviderEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool WmiProviderEnabled { get { return default(bool); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class DnsElement : System.Configuration.ConfigurationElement {
    public DnsElement() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("value", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Value { get { return default(string); } set { } }
  }
  public partial class EndpointAddressElementBase : System.Configuration.ConfigurationElement {
    public EndpointAddressElementBase() { }
    [System.Configuration.ConfigurationPropertyAttribute("address", Options=(System.Configuration.ConfigurationPropertyOptions)(2), DefaultValue=null, IsRequired=true)]
    public System.Uri Address { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("headers", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.AddressHeaderCollectionElement Headers { get { return default(System.ServiceModel.Configuration.AddressHeaderCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("identity", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IdentityElement Identity { get { return default(System.ServiceModel.Configuration.IdentityElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public partial class EndpointBehaviorElement : System.ServiceModel.Configuration.NamedServiceModelExtensionCollectionElement<System.ServiceModel.Configuration.BehaviorExtensionElement> {
    public EndpointBehaviorElement() { }
    public EndpointBehaviorElement(string name) { }
    public override void Add(System.ServiceModel.Configuration.BehaviorExtensionElement element) { }
    public override bool CanAdd(System.ServiceModel.Configuration.BehaviorExtensionElement element) { return default(bool); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.EndpointBehaviorElement), AddItemName="behavior", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class EndpointBehaviorElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.EndpointBehaviorElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public EndpointBehaviorElementCollection() { }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public partial class ExtensionElement : System.Configuration.ConfigurationElement {
    public ExtensionElement() { }
    public ExtensionElement(string name) { }
    public ExtensionElement(string name, string type) { }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", Options=(System.Configuration.ConfigurationPropertyOptions)(2), IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Type { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ExtensionElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
  public partial class ExtensionElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.ExtensionElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ExtensionElementCollection() { }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    protected override void BaseAdd(System.Configuration.ConfigurationElement element) { }
    protected override void BaseAdd(int index, System.Configuration.ConfigurationElement element) { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public partial class ExtensionsSection : System.Configuration.ConfigurationSection {
    public ExtensionsSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("behaviorExtensions", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ExtensionElementCollection BehaviorExtensions { get { return default(System.ServiceModel.Configuration.ExtensionElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("bindingElementExtensions", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ExtensionElementCollection BindingElementExtensions { get { return default(System.ServiceModel.Configuration.ExtensionElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("bindingExtensions", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ExtensionElementCollection BindingExtensions { get { return default(System.ServiceModel.Configuration.ExtensionElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected override void InitializeDefault() { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class FederatedMessageSecurityOverHttpElement : System.Configuration.ConfigurationElement {
    public FederatedMessageSecurityOverHttpElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.SecurityAlgorithmSuiteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("algorithmSuite", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Default")]
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("claimTypeRequirements", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ClaimTypeElementCollection ClaimTypeRequirements { get { return default(System.ServiceModel.Configuration.ClaimTypeElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("establishSecurityContext", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool EstablishSecurityContext { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("issuedKeyType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="SymmetricKey")]
    public System.IdentityModel.Tokens.SecurityKeyType IssuedKeyType { get { return default(System.IdentityModel.Tokens.SecurityKeyType); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("issuedTokenType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string IssuedTokenType { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("issuer", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IssuedTokenParametersEndpointAddressElement Issuer { get { return default(System.ServiceModel.Configuration.IssuedTokenParametersEndpointAddressElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("issuerMetadata", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.EndpointAddressElementBase IssuerMetadata { get { return default(System.ServiceModel.Configuration.EndpointAddressElementBase); } }
    [System.Configuration.ConfigurationPropertyAttribute("negotiateServiceCredential", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool NegotiateServiceCredential { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("tokenRequestParameters", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlElementElementCollection TokenRequestParameters { get { return default(System.ServiceModel.Configuration.XmlElementElementCollection); } }
  }
  public sealed partial class HostElement : System.Configuration.ConfigurationElement {
    public HostElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("baseAddresses", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.BaseAddressElementCollection BaseAddresses { get { return default(System.ServiceModel.Configuration.BaseAddressElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("timeouts", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.HostTimeoutsElement Timeouts { get { return default(System.ServiceModel.Configuration.HostTimeoutsElement); } }
  }
  public sealed partial class HostTimeoutsElement : System.Configuration.ConfigurationElement {
    public HostTimeoutsElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("closeTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:00:10")]
    public System.TimeSpan CloseTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("openTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:01:00")]
    public System.TimeSpan OpenTimeout { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class HttpDigestClientElement : System.Configuration.ConfigurationElement {
    public HttpDigestClientElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("impersonationLevel", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=(System.Security.Principal.TokenImpersonationLevel)(2))]
    public System.Security.Principal.TokenImpersonationLevel ImpersonationLevel { get { return default(System.Security.Principal.TokenImpersonationLevel); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public partial class HttpsTransportElement : System.ServiceModel.Configuration.HttpTransportElement {
    public HttpsTransportElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("requireClientCertificate", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool RequireClientCertificate { get { return default(bool); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected override System.ServiceModel.Channels.TransportBindingElement CreateDefaultBindingElement() { return default(System.ServiceModel.Channels.TransportBindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  public partial class HttpTransportElement : System.ServiceModel.Configuration.TransportElement {
    public HttpTransportElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("allowCookies", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool AllowCookies { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("authenticationScheme", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Anonymous")]
    public System.Net.AuthenticationSchemes AuthenticationScheme { get { return default(System.Net.AuthenticationSchemes); } set { } }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("bypassProxyOnLocal", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="StrongWildcard")]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("keepAliveEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool KeepAliveEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxBufferSize { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("proxyAddress", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=null)]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("proxyAuthenticationScheme", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Anonymous")]
    public System.Net.AuthenticationSchemes ProxyAuthenticationScheme { get { return default(System.Net.AuthenticationSchemes); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("realm", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Realm { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Buffered")]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("unsafeConnectionNtlmAuthentication", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool UnsafeConnectionNtlmAuthentication { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useDefaultWebProxy", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected override System.ServiceModel.Channels.TransportBindingElement CreateDefaultBindingElement() { return default(System.ServiceModel.Channels.TransportBindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class HttpTransportSecurityElement : System.Configuration.ConfigurationElement {
    public HttpTransportSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("clientCredentialType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=(System.ServiceModel.HttpClientCredentialType)(0))]
    public System.ServiceModel.HttpClientCredentialType ClientCredentialType { get { return default(System.ServiceModel.HttpClientCredentialType); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("proxyCredentialType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=(System.ServiceModel.HttpProxyCredentialType)(0))]
    public System.ServiceModel.HttpProxyCredentialType ProxyCredentialType { get { return default(System.ServiceModel.HttpProxyCredentialType); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("realm", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Realm { get { return default(string); } set { } }
  }
  public partial interface IBindingConfigurationElement {
    System.TimeSpan CloseTimeout { get; }
    string Name { get; }
    System.TimeSpan OpenTimeout { get; }
    System.TimeSpan ReceiveTimeout { get; }
    System.TimeSpan SendTimeout { get; }
    void ApplyConfiguration(System.ServiceModel.Channels.Binding binding);
  }
  public sealed partial class IdentityElement : System.Configuration.ConfigurationElement {
    public IdentityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("certificate", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.CertificateElement Certificate { get { return default(System.ServiceModel.Configuration.CertificateElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("certificateReference", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.CertificateReferenceElement CertificateReference { get { return default(System.ServiceModel.Configuration.CertificateReferenceElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("dns", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.DnsElement Dns { get { return default(System.ServiceModel.Configuration.DnsElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("rsa", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.RsaElement Rsa { get { return default(System.ServiceModel.Configuration.RsaElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("servicePrincipalName", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ServicePrincipalNameElement ServicePrincipalName { get { return default(System.ServiceModel.Configuration.ServicePrincipalNameElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("userPrincipalName", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.UserPrincipalNameElement UserPrincipalName { get { return default(System.ServiceModel.Configuration.UserPrincipalNameElement); } }
    public void InitializeFrom(System.ServiceModel.EndpointIdentity identity) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class IssuedTokenClientBehaviorsElement : System.Configuration.ConfigurationElement {
    public IssuedTokenClientBehaviorsElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("behaviorConfiguration", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string BehaviorConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("issuerAddress", Options=(System.Configuration.ConfigurationPropertyOptions)(6), DefaultValue="", IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string IssuerAddress { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.IssuedTokenClientBehaviorsElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  [System.MonoTODOAttribute]
  public sealed partial class IssuedTokenClientBehaviorsElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.IssuedTokenClientBehaviorsElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public IssuedTokenClientBehaviorsElementCollection() { }
    [System.MonoTODOAttribute]
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class IssuedTokenClientElement : System.Configuration.ConfigurationElement {
    public IssuedTokenClientElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("cacheIssuedTokens", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool CacheIssuedTokens { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("defaultKeyEntropyMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="CombinedEntropy")]
    public System.ServiceModel.Security.SecurityKeyEntropyMode DefaultKeyEntropyMode { get { return default(System.ServiceModel.Security.SecurityKeyEntropyMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("issuedTokenRenewalThresholdPercentage", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="60")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=100, ExcludeRange=false)]
    public int IssuedTokenRenewalThresholdPercentage { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("issuerChannelBehaviors", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IssuedTokenClientBehaviorsElementCollection IssuerChannelBehaviors { get { return default(System.ServiceModel.Configuration.IssuedTokenClientBehaviorsElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("localIssuer", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IssuedTokenParametersEndpointAddressElement LocalIssuer { get { return default(System.ServiceModel.Configuration.IssuedTokenParametersEndpointAddressElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("localIssuerChannelBehaviors", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string LocalIssuerChannelBehaviors { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxIssuedTokenCachingTime", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10675199.02:48:05.4775807")]
    public System.TimeSpan MaxIssuedTokenCachingTime { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class IssuedTokenParametersElement : System.Configuration.ConfigurationElement {
    public IssuedTokenParametersElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("additionalRequestParameters", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlElementElementCollection AdditionalRequestParameters { get { return default(System.ServiceModel.Configuration.XmlElementElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("claimTypeRequirements", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ClaimTypeElementCollection ClaimTypeRequirements { get { return default(System.ServiceModel.Configuration.ClaimTypeElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("issuer", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IssuedTokenParametersEndpointAddressElement Issuer { get { return default(System.ServiceModel.Configuration.IssuedTokenParametersEndpointAddressElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("issuerMetadata", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.EndpointAddressElementBase IssuerMetadata { get { return default(System.ServiceModel.Configuration.EndpointAddressElementBase); } }
    [System.Configuration.ConfigurationPropertyAttribute("keySize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="0")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int KeySize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("keyType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="SymmetricKey")]
    public System.IdentityModel.Tokens.SecurityKeyType KeyType { get { return default(System.IdentityModel.Tokens.SecurityKeyType); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("tokenType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string TokenType { get { return default(string); } set { } }
  }
  public sealed partial class IssuedTokenParametersEndpointAddressElement : System.ServiceModel.Configuration.EndpointAddressElementBase {
    public IssuedTokenParametersEndpointAddressElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("binding", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Binding { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("bindingConfiguration", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string BindingConfiguration { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class IssuedTokenServiceElement : System.Configuration.ConfigurationElement {
    public IssuedTokenServiceElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("allowedAudienceUris")]
    public System.ServiceModel.Configuration.AllowedAudienceUriElementCollection AllowedAudienceUris { get { return default(System.ServiceModel.Configuration.AllowedAudienceUriElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("allowUntrustedRsaIssuers", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool AllowUntrustedRsaIssuers { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("audienceUriMode", DefaultValue=(System.IdentityModel.Selectors.AudienceUriMode)(2))]
    public System.IdentityModel.Selectors.AudienceUriMode AudienceUriMode { get { return default(System.IdentityModel.Selectors.AudienceUriMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("certificateValidationMode", DefaultValue=(System.ServiceModel.Security.X509CertificateValidationMode)(2))]
    public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { return default(System.ServiceModel.Security.X509CertificateValidationMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("customCertificateValidatorType", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string CustomCertificateValidatorType { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("knownCertificates", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509CertificateTrustedIssuerElementCollection KnownCertificates { get { return default(System.ServiceModel.Configuration.X509CertificateTrustedIssuerElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("revocationMode", DefaultValue=(System.Security.Cryptography.X509Certificates.X509RevocationMode)(1))]
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("samlSerializerType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string SamlSerializerType { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("trustedStoreLocation", DefaultValue=(System.Security.Cryptography.X509Certificates.StoreLocation)(2))]
    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
  }
  public sealed partial class LocalClientSecuritySettingsElement : System.Configuration.ConfigurationElement {
    public LocalClientSecuritySettingsElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("cacheCookies", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool CacheCookies { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("cookieRenewalThresholdPercentage", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="60")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=100, ExcludeRange=false)]
    public int CookieRenewalThresholdPercentage { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("detectReplays", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool DetectReplays { get { return default(bool); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxClockSkew", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:05:00")]
    public System.TimeSpan MaxClockSkew { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxCookieCachingTime", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10675199.02:48:05.4775807")]
    public System.TimeSpan MaxCookieCachingTime { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("reconnectTransportOnFailure", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool ReconnectTransportOnFailure { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("replayCacheSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="900000")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int ReplayCacheSize { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("replayWindow", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:05:00")]
    public System.TimeSpan ReplayWindow { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("sessionKeyRenewalInterval", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10:00:00")]
    public System.TimeSpan SessionKeyRenewalInterval { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("sessionKeyRolloverInterval", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:05:00")]
    public System.TimeSpan SessionKeyRolloverInterval { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("timestampValidityDuration", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:05:00")]
    public System.TimeSpan TimestampValidityDuration { get { return default(System.TimeSpan); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class LocalServiceSecuritySettingsElement : System.Configuration.ConfigurationElement {
    public LocalServiceSecuritySettingsElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("detectReplays", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool DetectReplays { get { return default(bool); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("inactivityTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:02:00")]
    public System.TimeSpan InactivityTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("issuedCookieLifetime", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10:00:00")]
    public System.TimeSpan IssuedCookieLifetime { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxCachedCookies", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="1000")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxCachedCookies { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("maxClockSkew", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:05:00")]
    public System.TimeSpan MaxClockSkew { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingSessions", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="128")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxPendingSessions { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxStatefulNegotiations", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="128")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxStatefulNegotiations { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("negotiationTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:01:00")]
    public System.TimeSpan NegotiationTimeout { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("reconnectTransportOnFailure", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool ReconnectTransportOnFailure { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("replayCacheSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="900000")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int ReplayCacheSize { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("replayWindow", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:05:00")]
    public System.TimeSpan ReplayWindow { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("sessionKeyRenewalInterval", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="15:00:00")]
    public System.TimeSpan SessionKeyRenewalInterval { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("sessionKeyRolloverInterval", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:05:00")]
    public System.TimeSpan SessionKeyRolloverInterval { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("timestampValidityDuration", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:05:00")]
    public System.TimeSpan TimestampValidityDuration { get { return default(System.TimeSpan); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class MessageLoggingElement : System.Configuration.ConfigurationElement {
    public MessageLoggingElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("filters", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=null)]
    public System.ServiceModel.Configuration.XPathMessageFilterElementCollection Filters { get { return default(System.ServiceModel.Configuration.XPathMessageFilterElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("logEntireMessage", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool LogEntireMessage { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("logMalformedMessages", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool LogMalformedMessages { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("logMessagesAtServiceLevel", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool LogMessagesAtServiceLevel { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("logMessagesAtTransportLevel", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool LogMessagesAtTransportLevel { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxMessagesToLog", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10000")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=-1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxMessagesToLog { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxSizeOfMessageToLog", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="262144")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=-1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxSizeOfMessageToLog { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public partial class MessageSecurityOverHttpElement : System.Configuration.ConfigurationElement {
    public MessageSecurityOverHttpElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.SecurityAlgorithmSuiteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("algorithmSuite", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Default")]
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("clientCredentialType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Windows")]
    public System.ServiceModel.MessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.MessageCredentialType); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("negotiateServiceCredential", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool NegotiateServiceCredential { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class MessageSecurityOverMsmqElement : System.Configuration.ConfigurationElement {
    public MessageSecurityOverMsmqElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.SecurityAlgorithmSuiteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("algorithmSuite", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Default")]
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("clientCredentialType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Windows")]
    public System.ServiceModel.MessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.MessageCredentialType); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class MessageSecurityOverTcpElement : System.Configuration.ConfigurationElement {
    public MessageSecurityOverTcpElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.SecurityAlgorithmSuiteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("algorithmSuite", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Default")]
    public System.ServiceModel.Security.SecurityAlgorithmSuite AlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("clientCredentialType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Windows")]
    public System.ServiceModel.MessageCredentialType ClientCredentialType { get { return default(System.ServiceModel.MessageCredentialType); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class MetadataElement : System.Configuration.ConfigurationElement {
    public MetadataElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("policyImporters", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.PolicyImporterElementCollection PolicyImporters { get { return default(System.ServiceModel.Configuration.PolicyImporterElementCollection); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("wsdlImporters", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WsdlImporterElementCollection WsdlImporters { get { return default(System.ServiceModel.Configuration.WsdlImporterElementCollection); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.IPolicyImportExtension> LoadPolicyImportExtensions() { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.IPolicyImportExtension>); }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.IWsdlImportExtension> LoadWsdlImportExtensions() { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.IWsdlImportExtension>); }
  }
  [System.MonoTODOAttribute]
  public abstract partial class MexBindingBindingCollectionElement<TStandardBinding, TBindingConfiguration> : System.ServiceModel.Configuration.StandardBindingCollectionElement<TStandardBinding, TBindingConfiguration> where TStandardBinding : System.ServiceModel.Channels.Binding where TBindingConfiguration : System.ServiceModel.Configuration.StandardBindingElement, new() {
    protected MexBindingBindingCollectionElement() { }
  }
  public abstract partial class MexBindingElement<TStandardBinding> : System.ServiceModel.Configuration.StandardBindingElement, System.ServiceModel.Configuration.IBindingConfigurationElement where TStandardBinding : System.ServiceModel.Channels.Binding {
    protected MexBindingElement(string name) { }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  public partial class MexHttpBindingCollectionElement : System.ServiceModel.Configuration.MexBindingBindingCollectionElement<System.ServiceModel.WSHttpBinding, System.ServiceModel.Configuration.MexHttpBindingElement> {
    public MexHttpBindingCollectionElement() { }
    protected internal override System.ServiceModel.Channels.Binding GetDefault() { return default(System.ServiceModel.Channels.Binding); }
  }
  public partial class MexHttpBindingElement : System.ServiceModel.Configuration.MexBindingElement<System.ServiceModel.WSHttpBinding>, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public MexHttpBindingElement() : base (default(string)) { }
    public MexHttpBindingElement(string name) : base (default(string)) { }
  }
  public partial class MexHttpsBindingCollectionElement : System.ServiceModel.Configuration.MexBindingBindingCollectionElement<System.ServiceModel.WSHttpBinding, System.ServiceModel.Configuration.MexHttpsBindingElement> {
    public MexHttpsBindingCollectionElement() { }
    protected internal override System.ServiceModel.Channels.Binding GetDefault() { return default(System.ServiceModel.Channels.Binding); }
  }
  public partial class MexHttpsBindingElement : System.ServiceModel.Configuration.MexBindingElement<System.ServiceModel.WSHttpBinding>, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public MexHttpsBindingElement() : base (default(string)) { }
    public MexHttpsBindingElement(string name) : base (default(string)) { }
  }
  [System.MonoTODOAttribute]
  public partial class MexNamedPipeBindingCollectionElement : System.ServiceModel.Configuration.MexBindingBindingCollectionElement<System.ServiceModel.Channels.CustomBinding, System.ServiceModel.Configuration.MexNamedPipeBindingElement> {
    public MexNamedPipeBindingCollectionElement() { }
  }
  public partial class MexNamedPipeBindingElement : System.ServiceModel.Configuration.MexBindingElement<System.ServiceModel.Channels.CustomBinding>, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public MexNamedPipeBindingElement() : base (default(string)) { }
    public MexNamedPipeBindingElement(string name) : base (default(string)) { }
  }
  [System.MonoTODOAttribute]
  public partial class MexTcpBindingCollectionElement : System.ServiceModel.Configuration.MexBindingBindingCollectionElement<System.ServiceModel.Channels.CustomBinding, System.ServiceModel.Configuration.MexTcpBindingElement> {
    public MexTcpBindingCollectionElement() { }
  }
  public partial class MexTcpBindingElement : System.ServiceModel.Configuration.MexBindingElement<System.ServiceModel.Channels.CustomBinding>, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public MexTcpBindingElement() : base (default(string)) { }
    public MexTcpBindingElement(string name) : base (default(string)) { }
  }
  [System.MonoTODOAttribute]
  public abstract partial class MsmqBindingElementBase : System.ServiceModel.Configuration.StandardBindingElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    protected MsmqBindingElementBase() { }
    [System.Configuration.ConfigurationPropertyAttribute("customDeadLetterQueue", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=null)]
    public System.Uri CustomDeadLetterQueue { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("deadLetterQueue", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="System")]
    public System.ServiceModel.DeadLetterQueue DeadLetterQueue { get { return default(System.ServiceModel.DeadLetterQueue); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("durable", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool Durable { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("exactlyOnce", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool ExactlyOnce { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxRetryCycles", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="2")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxRetryCycles { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("receiveErrorHandling", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Fault")]
    public System.ServiceModel.ReceiveErrorHandling ReceiveErrorHandling { get { return default(System.ServiceModel.ReceiveErrorHandling); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("receiveRetryCount", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="5")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int ReceiveRetryCount { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("retryCycleDelay", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:30:00")]
    public System.TimeSpan RetryCycleDelay { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("timeToLive", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="1.00:00:00")]
    public System.TimeSpan TimeToLive { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useMsmqTracing", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool UseMsmqTracing { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useSourceJournal", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool UseSourceJournal { get { return default(bool); } set { } }
  }
  public abstract partial class MsmqElementBase : System.ServiceModel.Configuration.TransportElement {
    protected MsmqElementBase() { }
    [System.Configuration.ConfigurationPropertyAttribute("customDeadLetterQueue", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=null)]
    public System.Uri CustomDeadLetterQueue { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("deadLetterQueue", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="System")]
    public System.ServiceModel.DeadLetterQueue DeadLetterQueue { get { return default(System.ServiceModel.DeadLetterQueue); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("durable", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool Durable { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("exactlyOnce", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool ExactlyOnce { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxRetryCycles", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="2")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxRetryCycles { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("msmqTransportSecurity", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.MsmqTransportSecurityElement MsmqTransportSecurity { get { return default(System.ServiceModel.Configuration.MsmqTransportSecurityElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("receiveErrorHandling", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Fault")]
    public System.ServiceModel.ReceiveErrorHandling ReceiveErrorHandling { get { return default(System.ServiceModel.ReceiveErrorHandling); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("receiveRetryCount", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="5")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int ReceiveRetryCount { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("retryCycleDelay", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:30:00")]
    public System.TimeSpan RetryCycleDelay { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("timeToLive", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="1.00:00:00")]
    public System.TimeSpan TimeToLive { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useMsmqTracing", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool UseMsmqTracing { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useSourceJournal", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool UseSourceJournal { get { return default(bool); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  [System.MonoTODOAttribute]
  public partial class MsmqIntegrationBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.MsmqIntegration.MsmqIntegrationBinding, System.ServiceModel.Configuration.MsmqIntegrationBindingElement> {
    public MsmqIntegrationBindingCollectionElement() { }
  }
  [System.MonoTODOAttribute]
  public partial class MsmqIntegrationBindingElement : System.ServiceModel.Configuration.MsmqBindingElementBase, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public MsmqIntegrationBindingElement() { }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.MsmqIntegrationSecurityElement Security { get { return default(System.ServiceModel.Configuration.MsmqIntegrationSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("serializationFormat", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Xml")]
    public System.ServiceModel.MsmqIntegration.MsmqMessageSerializationFormat SerializationFormat { get { return default(System.ServiceModel.MsmqIntegration.MsmqMessageSerializationFormat); } set { } }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  public sealed partial class MsmqIntegrationElement : System.ServiceModel.Configuration.MsmqElementBase {
    public MsmqIntegrationElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("serializationFormat", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Xml")]
    public System.ServiceModel.MsmqIntegration.MsmqMessageSerializationFormat SerializationFormat { get { return default(System.ServiceModel.MsmqIntegration.MsmqMessageSerializationFormat); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected override System.ServiceModel.Channels.TransportBindingElement CreateDefaultBindingElement() { return default(System.ServiceModel.Channels.TransportBindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class MsmqIntegrationSecurityElement : System.Configuration.ConfigurationElement {
    public MsmqIntegrationSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("mode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Transport")]
    public System.ServiceModel.MsmqIntegration.MsmqIntegrationSecurityMode Mode { get { return default(System.ServiceModel.MsmqIntegration.MsmqIntegrationSecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transport", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.MsmqTransportSecurityElement Transport { get { return default(System.ServiceModel.Configuration.MsmqTransportSecurityElement); } }
  }
  public sealed partial class MsmqTransportElement : System.ServiceModel.Configuration.MsmqElementBase {
    public MsmqTransportElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="8")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxPoolSize { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("queueTransferProtocol", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Native")]
    public System.ServiceModel.QueueTransferProtocol QueueTransferProtocol { get { return default(System.ServiceModel.QueueTransferProtocol); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useActiveDirectory", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool UseActiveDirectory { get { return default(bool); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected override System.ServiceModel.Channels.TransportBindingElement CreateDefaultBindingElement() { return default(System.ServiceModel.Channels.TransportBindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class MsmqTransportSecurityElement : System.Configuration.ConfigurationElement {
    public MsmqTransportSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("msmqAuthenticationMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="WindowsDomain")]
    public System.ServiceModel.MsmqAuthenticationMode MsmqAuthenticationMode { get { return default(System.ServiceModel.MsmqAuthenticationMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("msmqEncryptionAlgorithm", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="RC4Stream")]
    public System.ServiceModel.MsmqEncryptionAlgorithm MsmqEncryptionAlgorithm { get { return default(System.ServiceModel.MsmqEncryptionAlgorithm); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("msmqProtectionLevel", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Sign")]
    public System.Net.Security.ProtectionLevel MsmqProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("msmqSecureHashAlgorithm", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Sha1")]
    public System.ServiceModel.MsmqSecureHashAlgorithm MsmqSecureHashAlgorithm { get { return default(System.ServiceModel.MsmqSecureHashAlgorithm); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class MtomMessageEncodingElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public MtomMessageEncodingElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReadPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="64")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxReadPoolSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxWritePoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="16")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxWritePoolSize { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.MessageVersionConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("messageVersion", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Soap12WSAddressing10")]
    public System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="utf-8")]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class NamedPipeConnectionPoolSettingsElement : System.Configuration.ConfigurationElement {
    public NamedPipeConnectionPoolSettingsElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("groupName", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="default")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string GroupName { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("idleTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:02:00")]
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxOutboundConnectionsPerEndpoint", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxOutboundConnectionsPerEndpoint { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class NamedPipeTransportElement : System.ServiceModel.Configuration.ConnectionOrientedTransportElement {
    public NamedPipeTransportElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("connectionPoolSettings", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.NamedPipeConnectionPoolSettingsElement ConnectionPoolSettings { get { return default(System.ServiceModel.Configuration.NamedPipeConnectionPoolSettingsElement); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected override System.ServiceModel.Channels.TransportBindingElement CreateDefaultBindingElement() { return default(System.ServiceModel.Channels.TransportBindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class NamedPipeTransportSecurityElement : System.Configuration.ConfigurationElement {
    public NamedPipeTransportSecurityElement() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("protectionLevel", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="EncryptAndSign")]
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
  }
  public abstract partial class NamedServiceModelExtensionCollectionElement<TServiceModelExtensionElement> : System.ServiceModel.Configuration.ServiceModelExtensionCollectionElement<TServiceModelExtensionElement>, System.Collections.Generic.ICollection<TServiceModelExtensionElement>, System.Collections.Generic.IEnumerable<TServiceModelExtensionElement>, System.Collections.IEnumerable where TServiceModelExtensionElement : System.ServiceModel.Configuration.ServiceModelExtensionElement {
    internal NamedServiceModelExtensionCollectionElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public virtual string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.MonoTODOAttribute]
  public partial class NetMsmqBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.NetMsmqBinding, System.ServiceModel.Configuration.NetMsmqBindingElement> {
    public NetMsmqBindingCollectionElement() { }
  }
  [System.MonoTODOAttribute]
  public partial class NetMsmqBindingElement : System.ServiceModel.Configuration.MsmqBindingElementBase, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public NetMsmqBindingElement() { }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="524288")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("queueTransferProtocol", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Native")]
    public System.ServiceModel.QueueTransferProtocol QueueTransferProtocol { get { return default(System.ServiceModel.QueueTransferProtocol); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.NetMsmqSecurityElement Security { get { return default(System.ServiceModel.Configuration.NetMsmqSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("useActiveDirectory", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool UseActiveDirectory { get { return default(bool); } set { } }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class NetMsmqSecurityElement : System.Configuration.ConfigurationElement {
    public NetMsmqSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("message", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.MessageSecurityOverMsmqElement Message { get { return default(System.ServiceModel.Configuration.MessageSecurityOverMsmqElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("mode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Transport")]
    public System.ServiceModel.NetMsmqSecurityMode Mode { get { return default(System.ServiceModel.NetMsmqSecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transport", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.MsmqTransportSecurityElement Transport { get { return default(System.ServiceModel.Configuration.MsmqTransportSecurityElement); } }
  }
  [System.MonoTODOAttribute]
  public partial class NetNamedPipeBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.NetNamedPipeBinding, System.ServiceModel.Configuration.NetNamedPipeBindingElement> {
    public NetNamedPipeBindingCollectionElement() { }
  }
  public partial class NetNamedPipeBindingElement : System.ServiceModel.Configuration.StandardBindingElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public NetNamedPipeBindingElement() { }
    public NetNamedPipeBindingElement(string name) { }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="StrongWildcard")]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="524288")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxConnections", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxConnections { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.NetNamedPipeSecurityElement Security { get { return default(System.ServiceModel.Configuration.NetNamedPipeSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("transactionFlow", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool TransactionFlow { get { return default(bool); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TransactionProtocolConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("transactionProtocol", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="OleTransactions")]
    public System.ServiceModel.TransactionProtocol TransactionProtocol { get { return default(System.ServiceModel.TransactionProtocol); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Buffered")]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class NetNamedPipeSecurityElement : System.Configuration.ConfigurationElement {
    public NetNamedPipeSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("mode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Transport")]
    public System.ServiceModel.NetNamedPipeSecurityMode Mode { get { return default(System.ServiceModel.NetNamedPipeSecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transport", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.NamedPipeTransportSecurityElement Transport { get { return default(System.ServiceModel.Configuration.NamedPipeTransportSecurityElement); } }
  }
  [System.MonoTODOAttribute]
  public partial class NetPeerTcpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.NetPeerTcpBinding, System.ServiceModel.Configuration.NetPeerTcpBindingElement> {
    public NetPeerTcpBindingCollectionElement() { }
  }
  public partial class NetPeerTcpBindingElement : System.ServiceModel.Configuration.StandardBindingElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public NetPeerTcpBindingElement() { }
    public NetPeerTcpBindingElement(string name) { }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("listenIPAddress", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=null)]
    [System.MonoTODOAttribute("get converter for IPAddress")]
    public System.Net.IPAddress ListenIPAddress { get { return default(System.Net.IPAddress); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="524288")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)16384, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("port", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="0")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=65535, ExcludeRange=false)]
    public int Port { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("resolver", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=null)]
    public System.ServiceModel.Configuration.PeerResolverElement Resolver { get { return default(System.ServiceModel.Configuration.PeerResolverElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.PeerSecurityElement Security { get { return default(System.ServiceModel.Configuration.PeerSecurityElement); } }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  [System.MonoTODOAttribute]
  public partial class NetTcpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.NetTcpBinding, System.ServiceModel.Configuration.NetTcpBindingElement> {
    public NetTcpBindingCollectionElement() { }
  }
  public partial class NetTcpBindingElement : System.ServiceModel.Configuration.StandardBindingElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public NetTcpBindingElement() { }
    public NetTcpBindingElement(string name) { }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="StrongWildcard")]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("listenBacklog", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int ListenBacklog { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="524288")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxBufferSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxConnections", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxConnections { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("portSharingEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool PortSharingEnabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("reliableSession", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.MonoTODOAttribute("This configuration prpperty is not applied yet")]
    public System.ServiceModel.Configuration.StandardBindingOptionalReliableSessionElement ReliableSession { get { return default(System.ServiceModel.Configuration.StandardBindingOptionalReliableSessionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.NetTcpSecurityElement Security { get { return default(System.ServiceModel.Configuration.NetTcpSecurityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("transactionFlow", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool TransactionFlow { get { return default(bool); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TransactionProtocolConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("transactionProtocol", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="OleTransactions")]
    public System.ServiceModel.TransactionProtocol TransactionProtocol { get { return default(System.ServiceModel.TransactionProtocol); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("transferMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Buffered")]
    public System.ServiceModel.TransferMode TransferMode { get { return default(System.ServiceModel.TransferMode); } set { } }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class NetTcpSecurityElement : System.Configuration.ConfigurationElement {
    public NetTcpSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("message", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.MessageSecurityOverTcpElement Message { get { return default(System.ServiceModel.Configuration.MessageSecurityOverTcpElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("mode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Transport")]
    public System.ServiceModel.SecurityMode Mode { get { return default(System.ServiceModel.SecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transport", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.TcpTransportSecurityElement Transport { get { return default(System.ServiceModel.Configuration.TcpTransportSecurityElement); } }
  }
  public sealed partial class NonDualMessageSecurityOverHttpElement : System.ServiceModel.Configuration.MessageSecurityOverHttpElement {
    public NonDualMessageSecurityOverHttpElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("establishSecurityContext", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool EstablishSecurityContext { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class OneWayElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public OneWayElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("channelPoolSettings", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.ChannelPoolSettingsElement ChannelPoolSettings { get { return default(System.ServiceModel.Configuration.ChannelPoolSettingsElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxAcceptedChannels", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxAcceptedChannels { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("packetRoutable", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool PacketRoutable { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class PeerCredentialElement : System.Configuration.ConfigurationElement {
    public PeerCredentialElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("certificate", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509PeerCertificateElement Certificate { get { return default(System.ServiceModel.Configuration.X509PeerCertificateElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("messageSenderAuthentication", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509PeerCertificateAuthenticationElement MessageSenderAuthentication { get { return default(System.ServiceModel.Configuration.X509PeerCertificateAuthenticationElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("peerAuthentication", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509PeerCertificateAuthenticationElement PeerAuthentication { get { return default(System.ServiceModel.Configuration.X509PeerCertificateAuthenticationElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class PeerCustomResolverElement : System.Configuration.ConfigurationElement {
    public PeerCustomResolverElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("address", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=null)]
    public System.Uri Address { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("binding", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Binding { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("bindingConfiguration", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string BindingConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("headers", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.AddressHeaderCollectionElement Headers { get { return default(System.ServiceModel.Configuration.AddressHeaderCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("identity", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IdentityElement Identity { get { return default(System.ServiceModel.Configuration.IdentityElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("resolverType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string ResolverType { get { return default(string); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class PeerResolverElement : System.Configuration.ConfigurationElement {
    public PeerResolverElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("custom", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.PeerCustomResolverElement Custom { get { return default(System.ServiceModel.Configuration.PeerCustomResolverElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("mode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Auto")]
    public System.ServiceModel.PeerResolvers.PeerResolverMode Mode { get { return default(System.ServiceModel.PeerResolvers.PeerResolverMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("referralPolicy", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Service")]
    public System.ServiceModel.PeerResolvers.PeerReferralPolicy ReferralPolicy { get { return default(System.ServiceModel.PeerResolvers.PeerReferralPolicy); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class PeerSecurityElement : System.Configuration.ConfigurationElement {
    public PeerSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("mode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Transport")]
    public System.ServiceModel.SecurityMode Mode { get { return default(System.ServiceModel.SecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transport", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.PeerTransportSecurityElement Transport { get { return default(System.ServiceModel.Configuration.PeerTransportSecurityElement); } }
  }
  public partial class PeerTransportElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public PeerTransportElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.IPAddressConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("listenIPAddress", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=null)]
    public System.Net.IPAddress ListenIPAddress { get { return default(System.Net.IPAddress); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="524288")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("port", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="0")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=65535, ExcludeRange=false)]
    public int Port { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.PeerSecurityElement Security { get { return default(System.ServiceModel.Configuration.PeerSecurityElement); } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class PeerTransportSecurityElement : System.Configuration.ConfigurationElement {
    public PeerTransportSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("credentialType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Password")]
    public System.ServiceModel.PeerTransportCredentialType CredentialType { get { return default(System.ServiceModel.PeerTransportCredentialType); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public partial class PnrpPeerResolverElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public PnrpPeerResolverElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  public sealed partial class PolicyImporterElement : System.Configuration.ConfigurationElement {
    public PolicyImporterElement() { }
    public PolicyImporterElement(string type) { }
    public PolicyImporterElement(System.Type type) { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Type { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.PolicyImporterElement), AddItemName="extension", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class PolicyImporterElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.PolicyImporterElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public PolicyImporterElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public partial class PrivacyNoticeElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public PrivacyNoticeElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("url", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri Url { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("version", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="0")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int Version { get { return default(int); } set { } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  public sealed partial class ReliableSessionElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public ReliableSessionElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("acknowledgementInterval", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:00:00.2")]
    public System.TimeSpan AcknowledgementInterval { get { return default(System.TimeSpan); } set { } }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("flowControlEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool FlowControlEnabled { get { return default(bool); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("inactivityTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:10:00")]
    public System.TimeSpan InactivityTimeout { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxPendingChannels", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="4")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=16384, ExcludeRange=false)]
    public int MaxPendingChannels { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxRetryCount", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="8")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxRetryCount { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxTransferWindowSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="8")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=4096, ExcludeRange=false)]
    public int MaxTransferWindowSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("ordered", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool Ordered { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.ReliableMessagingVersionConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("reliableMessagingVersion", DefaultValue="WSReliableMessagingFebruary2005")]
    public System.ServiceModel.ReliableMessagingVersion ReliableMessagingVersion { get { return default(System.ServiceModel.ReliableMessagingVersion); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement element) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement element) { }
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement element) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class RsaElement : System.Configuration.ConfigurationElement {
    public RsaElement() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("value", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Value { get { return default(string); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class SecureConversationServiceElement : System.Configuration.ConfigurationElement {
    public SecureConversationServiceElement() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("securityStateEncoderType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string SecurityStateEncoderType { get { return default(string); } set { } }
  }
  public sealed partial class SecurityElement : System.ServiceModel.Configuration.SecurityElementBase {
    public SecurityElement() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("secureConversationBootstrap", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.SecurityElementBase SecureConversationBootstrap { get { return default(System.ServiceModel.Configuration.SecurityElementBase); } }
  }
  public partial class SecurityElementBase : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public SecurityElementBase() { }
    [System.Configuration.ConfigurationPropertyAttribute("allowSerializedSigningTokenOnReply", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool AllowSerializedSigningTokenOnReply { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("authenticationMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="SspiNegotiated")]
    public System.ServiceModel.Configuration.AuthenticationMode AuthenticationMode { get { return default(System.ServiceModel.Configuration.AuthenticationMode); } set { } }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.SecurityAlgorithmSuiteConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("defaultAlgorithmSuite", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Default")]
    public System.ServiceModel.Security.SecurityAlgorithmSuite DefaultAlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("includeTimestamp", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool IncludeTimestamp { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("issuedTokenParameters", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IssuedTokenParametersElement IssuedTokenParameters { get { return default(System.ServiceModel.Configuration.IssuedTokenParametersElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("keyEntropyMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="CombinedEntropy")]
    public System.ServiceModel.Security.SecurityKeyEntropyMode KeyEntropyMode { get { return default(System.ServiceModel.Security.SecurityKeyEntropyMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("localClientSettings", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.LocalClientSecuritySettingsElement LocalClientSettings { get { return default(System.ServiceModel.Configuration.LocalClientSecuritySettingsElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("localServiceSettings", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.LocalServiceSecuritySettingsElement LocalServiceSettings { get { return default(System.ServiceModel.Configuration.LocalServiceSecuritySettingsElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("messageProtectionOrder", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="SignBeforeEncryptAndEncryptSignature")]
    public System.ServiceModel.Security.MessageProtectionOrder MessageProtectionOrder { get { return default(System.ServiceModel.Security.MessageProtectionOrder); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.MessageSecurityVersionConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("messageSecurityVersion", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Default")]
    public System.ServiceModel.MessageSecurityVersion MessageSecurityVersion { get { return default(System.ServiceModel.MessageSecurityVersion); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("requireDerivedKeys", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool RequireDerivedKeys { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("requireSecurityContextCancellation", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool RequireSecurityContextCancellation { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("requireSignatureConfirmation", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool RequireSignatureConfirmation { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("securityHeaderLayout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Strict")]
    public System.ServiceModel.Channels.SecurityHeaderLayout SecurityHeaderLayout { get { return default(System.ServiceModel.Channels.SecurityHeaderLayout); } set { } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  public sealed partial class ServiceAuthorizationElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public ServiceAuthorizationElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("authorizationPolicies", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.AuthorizationPolicyTypeElementCollection AuthorizationPolicies { get { return default(System.ServiceModel.Configuration.AuthorizationPolicyTypeElementCollection); } }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("impersonateCallerForAllOperations", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool ImpersonateCallerForAllOperations { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("principalPermissionMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="UseWindowsGroups")]
    public System.ServiceModel.Description.PrincipalPermissionMode PrincipalPermissionMode { get { return default(System.ServiceModel.Description.PrincipalPermissionMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("roleProviderName", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string RoleProviderName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("serviceAuthorizationManagerType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string ServiceAuthorizationManagerType { get { return default(string); } set { } }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    [System.MonoTODOAttribute]
    protected internal override object CreateBehavior() { return default(object); }
  }
  public partial class ServiceBehaviorElement : System.ServiceModel.Configuration.NamedServiceModelExtensionCollectionElement<System.ServiceModel.Configuration.BehaviorExtensionElement> {
    public ServiceBehaviorElement() { }
    public ServiceBehaviorElement(string name) { }
    public override void Add(System.ServiceModel.Configuration.BehaviorExtensionElement element) { }
    public override bool CanAdd(System.ServiceModel.Configuration.BehaviorExtensionElement element) { return default(bool); }
    protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ServiceBehaviorElement), AddItemName="behavior", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class ServiceBehaviorElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.ServiceBehaviorElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ServiceBehaviorElementCollection() { }
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public partial class ServiceCredentialsElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public ServiceCredentialsElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("clientCertificate", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509InitiatorCertificateServiceElement ClientCertificate { get { return default(System.ServiceModel.Configuration.X509InitiatorCertificateServiceElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("issuedTokenAuthentication", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IssuedTokenServiceElement IssuedTokenAuthentication { get { return default(System.ServiceModel.Configuration.IssuedTokenServiceElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("peer", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.PeerCredentialElement Peer { get { return default(System.ServiceModel.Configuration.PeerCredentialElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("secureConversationAuthentication", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.SecureConversationServiceElement SecureConversationAuthentication { get { return default(System.ServiceModel.Configuration.SecureConversationServiceElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("serviceCertificate", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509RecipientCertificateServiceElement ServiceCertificate { get { return default(System.ServiceModel.Configuration.X509RecipientCertificateServiceElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Type { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("userNameAuthentication", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.UserNameServiceElement UserNameAuthentication { get { return default(System.ServiceModel.Configuration.UserNameServiceElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("windowsAuthentication", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WindowsServiceElement WindowsAuthentication { get { return default(System.ServiceModel.Configuration.WindowsServiceElement); } }
    protected internal void ApplyConfiguration(System.ServiceModel.Description.ServiceCredentials sb) { }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class ServiceDebugElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public ServiceDebugElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("httpHelpPageBinding", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string HttpHelpPageBinding { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpHelpPageBindingConfiguration", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string HttpHelpPageBindingConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpHelpPageEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool HttpHelpPageEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpHelpPageUrl", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri HttpHelpPageUrl { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpsHelpPageBinding", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string HttpsHelpPageBinding { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpsHelpPageBindingConfiguration", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string HttpsHelpPageBindingConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpsHelpPageEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool HttpsHelpPageEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpsHelpPageUrl", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri HttpsHelpPageUrl { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("includeExceptionDetailInFaults", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool IncludeExceptionDetailInFaults { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class ServiceElement : System.Configuration.ConfigurationElement {
    public ServiceElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("behaviorConfiguration", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string BehaviorConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1), IsDefaultCollection=true)]
    public System.ServiceModel.Configuration.ServiceEndpointElementCollection Endpoints { get { return default(System.ServiceModel.Configuration.ServiceEndpointElementCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("host", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.HostElement Host { get { return default(System.ServiceModel.Configuration.HostElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ServiceElement), AddItemName="service", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class ServiceElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.ServiceElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ServiceElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class ServiceEndpointElement : System.Configuration.ConfigurationElement {
    public ServiceEndpointElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("address", Options=(System.Configuration.ConfigurationPropertyOptions)(4), DefaultValue="", IsKey=true)]
    public System.Uri Address { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("behaviorConfiguration", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string BehaviorConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("binding", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Binding { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("bindingConfiguration", Options=(System.Configuration.ConfigurationPropertyOptions)(4), DefaultValue="", IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string BindingConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("bindingName", Options=(System.Configuration.ConfigurationPropertyOptions)(4), DefaultValue="", IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string BindingName { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("bindingNamespace", Options=(System.Configuration.ConfigurationPropertyOptions)(4), DefaultValue="", IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string BindingNamespace { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("contract", Options=(System.Configuration.ConfigurationPropertyOptions)(4), DefaultValue="", IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Contract { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("headers", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.AddressHeaderCollectionElement Headers { get { return default(System.ServiceModel.Configuration.AddressHeaderCollectionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("identity", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.IdentityElement Identity { get { return default(System.ServiceModel.Configuration.IdentityElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("listenUri", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=null)]
    public System.Uri ListenUri { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("listenUriMode", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Explicit")]
    public System.ServiceModel.Description.ListenUriMode ListenUriMode { get { return default(System.ServiceModel.Description.ListenUriMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.ServiceEndpointElement), AddItemName="endpoint", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class ServiceEndpointElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.ServiceEndpointElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public ServiceEndpointElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class ServiceHostingEnvironmentSection : System.Configuration.ConfigurationSection {
    public ServiceHostingEnvironmentSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("aspNetCompatibilityEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool AspNetCompatibilityEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("minFreeMemoryPercentageToActivateService", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="5")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=99, ExcludeRange=false)]
    public int MinFreeMemoryPercentageToActivateService { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1), IsDefaultCollection=true)]
    public System.ServiceModel.Configuration.TransportConfigurationTypeElementCollection TransportConfigurationTypes { get { return default(System.ServiceModel.Configuration.TransportConfigurationTypeElementCollection); } }
  }
  public sealed partial class ServiceMetadataPublishingElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public ServiceMetadataPublishingElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("externalMetadataLocation", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri ExternalMetadataLocation { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpGetBinding", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string HttpGetBinding { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpGetBindingConfiguration", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string HttpGetBindingConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpGetEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool HttpGetEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpGetUrl", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri HttpGetUrl { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpsGetBinding", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string HttpsGetBinding { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpsGetBindingConfiguration", DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0)]
    public string HttpsGetBindingConfiguration { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpsGetEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool HttpsGetEnabled { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("httpsGetUrl", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri HttpsGetUrl { get { return default(System.Uri); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.PolicyVersionConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("policyVersion", DefaultValue="Default")]
    public System.ServiceModel.Description.PolicyVersion PolicyVersion { get { return default(System.ServiceModel.Description.PolicyVersion); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public abstract partial class ServiceModelConfigurationElementCollection<ConfigurationElementType> : System.Configuration.ConfigurationElementCollection where ConfigurationElementType : System.Configuration.ConfigurationElement, new() {
    internal ServiceModelConfigurationElementCollection() { }
    public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { return default(System.Configuration.ConfigurationElementCollectionType); } }
    protected override string ElementName { get { return default(string); } }
    public ConfigurationElementType this[int index] { get { return default(ConfigurationElementType); } set { } }
    public virtual ConfigurationElementType this[object key] { get { return default(ConfigurationElementType); } set { } }
    public void Add(ConfigurationElementType element) { }
    protected override void BaseAdd(System.Configuration.ConfigurationElement element) { }
    public void Clear() { }
    public virtual bool ContainsKey(object key) { return default(bool); }
    public void CopyTo(ConfigurationElementType[] array, int index) { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    public int IndexOf(ConfigurationElementType item) { return default(int); }
    public void Remove(ConfigurationElementType item) { }
    public void RemoveAt(int index) { }
    public void RemoveAt(object index) { }
  }
  public abstract partial class ServiceModelEnhancedConfigurationElementCollection<TConfigurationElement> : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<TConfigurationElement>, System.Collections.ICollection, System.Collections.IEnumerable where TConfigurationElement : System.Configuration.ConfigurationElement, new() {
    internal ServiceModelEnhancedConfigurationElementCollection() { }
    [System.MonoTODOAttribute]
    protected override bool ThrowOnDuplicate { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected override void BaseAdd(System.Configuration.ConfigurationElement element) { }
  }
  public abstract partial class ServiceModelExtensionCollectionElement<TServiceModelExtensionElement> : System.Configuration.ConfigurationElement, System.Collections.Generic.ICollection<TServiceModelExtensionElement>, System.Collections.Generic.IEnumerable<TServiceModelExtensionElement>, System.Collections.IEnumerable where TServiceModelExtensionElement : System.ServiceModel.Configuration.ServiceModelExtensionElement {
    internal ServiceModelExtensionCollectionElement() { }
    public int Count { get { return default(int); } }
    public TServiceModelExtensionElement this[int index] { get { return default(TServiceModelExtensionElement); } }
    public TServiceModelExtensionElement this[System.Type extensionType] { get { return default(TServiceModelExtensionElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    bool System.Collections.Generic.ICollection<TServiceModelExtensionElement>.IsReadOnly { get { return default(bool); } }
    public virtual void Add(TServiceModelExtensionElement element) { }
    public virtual bool CanAdd(TServiceModelExtensionElement element) { return default(bool); }
    public void Clear() { }
    public bool Contains(TServiceModelExtensionElement element) { return default(bool); }
    public bool ContainsKey(string elementName) { return default(bool); }
    public bool ContainsKey(System.Type elementType) { return default(bool); }
    public void CopyTo(TServiceModelExtensionElement[] elements, int start) { }
    protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
    [System.Diagnostics.DebuggerHiddenAttribute]
    public System.Collections.Generic.IEnumerator<TServiceModelExtensionElement> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<TServiceModelExtensionElement>); }
    protected override bool IsModified() { return default(bool); }
    protected override bool OnDeserializeUnrecognizedElement(string elementName, System.Xml.XmlReader reader) { return default(bool); }
    public bool Remove(TServiceModelExtensionElement element) { return default(bool); }
    protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
    protected override void ResetModified() { }
    protected void SetIsModified() { }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
  }
  [System.MonoTODOAttribute]
  public abstract partial class ServiceModelExtensionElement : System.Configuration.ConfigurationElement {
    protected ServiceModelExtensionElement() { }
    public string ConfigurationElementName { get { return default(string); } }
    public virtual void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected override bool IsModified() { return default(bool); }
    protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
    protected override bool SerializeElement(System.Xml.XmlWriter writer, bool serializeCollectionKey) { return default(bool); }
  }
  public sealed partial class ServiceModelSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public ServiceModelSectionGroup() { }
    public System.ServiceModel.Configuration.BehaviorsSection Behaviors { get { return default(System.ServiceModel.Configuration.BehaviorsSection); } }
    public System.ServiceModel.Configuration.BindingsSection Bindings { get { return default(System.ServiceModel.Configuration.BindingsSection); } }
    public System.ServiceModel.Configuration.ClientSection Client { get { return default(System.ServiceModel.Configuration.ClientSection); } }
    public System.ServiceModel.Configuration.CommonBehaviorsSection CommonBehaviors { get { return default(System.ServiceModel.Configuration.CommonBehaviorsSection); } }
    public System.ServiceModel.Configuration.DiagnosticSection Diagnostic { get { return default(System.ServiceModel.Configuration.DiagnosticSection); } }
    public System.ServiceModel.Configuration.ExtensionsSection Extensions { get { return default(System.ServiceModel.Configuration.ExtensionsSection); } }
    public System.ServiceModel.Configuration.ServiceHostingEnvironmentSection ServiceHostingEnvironment { get { return default(System.ServiceModel.Configuration.ServiceHostingEnvironmentSection); } }
    public System.ServiceModel.Configuration.ServicesSection Services { get { return default(System.ServiceModel.Configuration.ServicesSection); } }
    public static System.ServiceModel.Configuration.ServiceModelSectionGroup GetSectionGroup(System.Configuration.Configuration config) { return default(System.ServiceModel.Configuration.ServiceModelSectionGroup); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class ServicePrincipalNameElement : System.Configuration.ConfigurationElement {
    public ServicePrincipalNameElement() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("value", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Value { get { return default(string); } set { } }
  }
  public sealed partial class ServiceSecurityAuditElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public ServiceSecurityAuditElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("auditLogLocation", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Default")]
    public System.ServiceModel.AuditLogLocation AuditLogLocation { get { return default(System.ServiceModel.AuditLogLocation); } set { } }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("messageAuthenticationAuditLevel", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="None")]
    public System.ServiceModel.AuditLevel MessageAuthenticationAuditLevel { get { return default(System.ServiceModel.AuditLevel); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("serviceAuthorizationAuditLevel", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="None")]
    public System.ServiceModel.AuditLevel ServiceAuthorizationAuditLevel { get { return default(System.ServiceModel.AuditLevel); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("suppressAuditFailure", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool SuppressAuditFailure { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class ServicesSection : System.Configuration.ConfigurationSection {
    public ServicesSection() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1), IsDefaultCollection=true)]
    public System.ServiceModel.Configuration.ServiceElementCollection Services { get { return default(System.ServiceModel.Configuration.ServiceElementCollection); } }
  }
  public sealed partial class ServiceThrottlingElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public ServiceThrottlingElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxConcurrentCalls", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="16")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxConcurrentCalls { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxConcurrentInstances", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=26)]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxConcurrentInstances { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxConcurrentSessions", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxConcurrentSessions { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class ServiceTimeoutsElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public ServiceTimeoutsElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transactionTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:00:00")]
    public System.TimeSpan TransactionTimeout { get { return default(System.TimeSpan); } set { } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public sealed partial class SslStreamSecurityElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public SslStreamSecurityElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("requireClientCertificate", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool RequireClientCertificate { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  public partial class StandardBindingCollectionElement<TStandardBinding, TBindingConfiguration> : System.ServiceModel.Configuration.BindingCollectionElement where TStandardBinding : System.ServiceModel.Channels.Binding where TBindingConfiguration : System.ServiceModel.Configuration.StandardBindingElement, new() {
    public StandardBindingCollectionElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1), IsDefaultCollection=true)]
    public System.ServiceModel.Configuration.StandardBindingElementCollection<TBindingConfiguration> Bindings { get { return default(System.ServiceModel.Configuration.StandardBindingElementCollection<TBindingConfiguration>); } }
    public override System.Type BindingType { get { return default(System.Type); } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Configuration.IBindingConfigurationElement> ConfiguredBindings { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Configuration.IBindingConfigurationElement>); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public override bool ContainsKey(string name) { return default(bool); }
    protected internal override System.ServiceModel.Channels.Binding GetDefault() { return default(System.ServiceModel.Channels.Binding); }
    protected internal override bool TryAdd(string name, System.ServiceModel.Channels.Binding binding, System.Configuration.Configuration config) { return default(bool); }
  }
  public abstract partial class StandardBindingElement : System.Configuration.ConfigurationElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    protected StandardBindingElement() { }
    protected StandardBindingElement(string name) { }
    protected abstract System.Type BindingElementType { get; }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("closeTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:01:00")]
    public System.TimeSpan CloseTimeout { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Name { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("openTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:01:00")]
    public System.TimeSpan OpenTimeout { get { return default(System.TimeSpan); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("receiveTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:10:00")]
    public System.TimeSpan ReceiveTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("sendTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:01:00")]
    public System.TimeSpan SendTimeout { get { return default(System.TimeSpan); } set { } }
    public void ApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
    protected internal virtual void InitializeFrom(System.ServiceModel.Channels.Binding binding) { }
    protected abstract void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding);
  }
  [System.MonoTODOAttribute]
  public sealed partial class StandardBindingElementCollection<TBindingConfiguration> : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<TBindingConfiguration>, System.Collections.ICollection, System.Collections.IEnumerable where TBindingConfiguration : System.ServiceModel.Configuration.StandardBindingElement, new() {
    public StandardBindingElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public sealed partial class StandardBindingOptionalReliableSessionElement : System.ServiceModel.Configuration.StandardBindingReliableSessionElement {
    public StandardBindingOptionalReliableSessionElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("enabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool Enabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public void ApplyConfiguration(System.ServiceModel.OptionalReliableSession s) { }
  }
  [System.MonoTODOAttribute]
  public partial class StandardBindingReliableSessionElement : System.Configuration.ConfigurationElement {
    public StandardBindingReliableSessionElement() { }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("inactivityTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:10:00")]
    public System.TimeSpan InactivityTimeout { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("ordered", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=true)]
    public bool Ordered { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public void ApplyConfiguration(System.ServiceModel.ReliableSession s) { }
  }
  public sealed partial class SynchronousReceiveElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public SynchronousReceiveElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class TcpConnectionPoolSettingsElement : System.Configuration.ConfigurationElement {
    public TcpConnectionPoolSettingsElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("groupName", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="default")]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string GroupName { get { return default(string); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("idleTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:02:00")]
    public System.TimeSpan IdleTimeout { get { return default(System.TimeSpan); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.TimeSpanConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("leaseTimeout", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="00:05:00")]
    public System.TimeSpan LeaseTimeout { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxOutboundConnectionsPerEndpoint", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxOutboundConnectionsPerEndpoint { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class TcpTransportElement : System.ServiceModel.Configuration.ConnectionOrientedTransportElement {
    public TcpTransportElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("connectionPoolSettings", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.TcpConnectionPoolSettingsElement ConnectionPoolSettings { get { return default(System.ServiceModel.Configuration.TcpConnectionPoolSettingsElement); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("listenBacklog", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="10")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int ListenBacklog { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("portSharingEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool PortSharingEnabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("teredoEnabled", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool TeredoEnabled { get { return default(bool); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected override System.ServiceModel.Channels.TransportBindingElement CreateDefaultBindingElement() { return default(System.ServiceModel.Channels.TransportBindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class TcpTransportSecurityElement : System.Configuration.ConfigurationElement {
    public TcpTransportSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("clientCredentialType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Windows")]
    public System.ServiceModel.TcpClientCredentialType ClientCredentialType { get { return default(System.ServiceModel.TcpClientCredentialType); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("protectionLevel", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="EncryptAndSign")]
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
  }
  public sealed partial class TextMessageEncodingElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public TextMessageEncodingElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReadPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="64")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxReadPoolSize { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxWritePoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="16")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxWritePoolSize { get { return default(int); } set { } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.MessageVersionConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("messageVersion", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="Soap12WSAddressing10")]
    public System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="utf-8")]
    public System.Text.Encoding WriteEncoding { get { return default(System.Text.Encoding); } set { } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement element) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement element) { }
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement element) { }
  }
  public sealed partial class TransactedBatchingElement : System.ServiceModel.Configuration.BehaviorExtensionElement {
    public TransactedBatchingElement() { }
    public override System.Type BehaviorType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBatchSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="0")]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxBatchSize { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    protected internal override object CreateBehavior() { return default(object); }
  }
  public partial class TransactionFlowElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public TransactionFlowElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.TransactionProtocolConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("transactionProtocol", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="OleTransactions")]
    public System.ServiceModel.TransactionProtocol TransactionProtocol { get { return default(System.ServiceModel.TransactionProtocol); } set { } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class TransportConfigurationTypeElement : System.Configuration.ConfigurationElement {
    public TransportConfigurationTypeElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transportConfigurationType", Options=(System.Configuration.ConfigurationPropertyOptions)(2), IsRequired=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string TransportConfigurationType { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.TransportConfigurationTypeElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  [System.MonoTODOAttribute]
  public sealed partial class TransportConfigurationTypeElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.TransportConfigurationTypeElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public TransportConfigurationTypeElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  public abstract partial class TransportElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    protected TransportElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("manualAddressing", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue=false)]
    public bool ManualAddressing { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="524288")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="65536")]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
    public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
    protected abstract System.ServiceModel.Channels.TransportBindingElement CreateDefaultBindingElement();
    protected internal override void InitializeFrom(System.ServiceModel.Channels.BindingElement bindingElement) { }
  }
  public partial class UseManagedPresentationElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public UseManagedPresentationElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  public sealed partial class UserNameServiceElement : System.Configuration.ConfigurationElement {
    public UserNameServiceElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("cachedLogonTokenLifetime", DefaultValue="00:15:00", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.TimeSpan CachedLogonTokenLifetime { get { return default(System.TimeSpan); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("cacheLogonTokens", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool CacheLogonTokens { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("customUserNamePasswordValidatorType", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string CustomUserNamePasswordValidatorType { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("includeWindowsGroups", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool IncludeWindowsGroups { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxCachedLogonTokens", DefaultValue="128", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxCachedLogonTokens { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("membershipProviderName", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string MembershipProviderName { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("userNamePasswordValidationMode", DefaultValue="Windows", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Security.UserNamePasswordValidationMode UserNamePasswordValidationMode { get { return default(System.ServiceModel.Security.UserNamePasswordValidationMode); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class UserPrincipalNameElement : System.Configuration.ConfigurationElement {
    public UserPrincipalNameElement() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("value", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Value { get { return default(string); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class WindowsClientElement : System.Configuration.ConfigurationElement {
    public WindowsClientElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("allowedImpersonationLevel", DefaultValue="Identification", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Principal.TokenImpersonationLevel AllowedImpersonationLevel { get { return default(System.Security.Principal.TokenImpersonationLevel); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("allowNtlm", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool AllowNtlm { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class WindowsServiceElement : System.Configuration.ConfigurationElement {
    public WindowsServiceElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("allowAnonymousLogons", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool AllowAnonymousLogons { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("includeWindowsGroups", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool IncludeWindowsGroups { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class WindowsStreamSecurityElement : System.ServiceModel.Configuration.BindingElementExtensionElement {
    public WindowsStreamSecurityElement() { }
    public override System.Type BindingElementType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("protectionLevel", DefaultValue="EncryptAndSign", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { return default(System.ServiceModel.Channels.BindingElement); }
  }
  [System.MonoTODOAttribute]
  public partial class WS2007FederationHttpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.WS2007FederationHttpBinding, System.ServiceModel.Configuration.WS2007FederationHttpBindingElement> {
    public WS2007FederationHttpBindingCollectionElement() { }
  }
  [System.MonoTODOAttribute]
  public partial class WS2007FederationHttpBindingElement : System.ServiceModel.Configuration.WSFederationHttpBindingElement {
    public WS2007FederationHttpBindingElement() { }
  }
  [System.MonoTODOAttribute]
  public partial class WS2007HttpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.WS2007HttpBinding, System.ServiceModel.Configuration.WS2007HttpBindingElement> {
    public WS2007HttpBindingCollectionElement() { }
  }
  [System.MonoTODOAttribute]
  public partial class WS2007HttpBindingElement : System.ServiceModel.Configuration.WSHttpBindingElement {
    public WS2007HttpBindingElement() { }
  }
  public sealed partial class WsdlImporterElement : System.Configuration.ConfigurationElement {
    public WsdlImporterElement() { }
    public WsdlImporterElement(string type) { }
    public WsdlImporterElement(System.Type type) { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=1, MaxLength=2147483647, InvalidCharacters=null)]
    public string Type { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.WsdlImporterElement), AddItemName="extension", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class WsdlImporterElementCollection : System.ServiceModel.Configuration.ServiceModelEnhancedConfigurationElementCollection<System.ServiceModel.Configuration.WsdlImporterElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public WsdlImporterElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  [System.MonoTODOAttribute]
  public partial class WSDualHttpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.WSDualHttpBinding, System.ServiceModel.Configuration.WSDualHttpBindingElement> {
    public WSDualHttpBindingCollectionElement() { }
  }
  [System.MonoTODOAttribute]
  public partial class WSDualHttpBindingElement : System.ServiceModel.Configuration.StandardBindingElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public WSDualHttpBindingElement() { }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("bypassProxyOnLocal", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("clientBaseAddress", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri ClientBaseAddress { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue="StrongWildcard", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue="524288", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue="65536", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("messageEncoding", DefaultValue="Text", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.WSMessageEncoding MessageEncoding { get { return default(System.ServiceModel.WSMessageEncoding); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("proxyAddress", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("reliableSession", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.StandardBindingReliableSessionElement ReliableSession { get { return default(System.ServiceModel.Configuration.StandardBindingReliableSessionElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WSDualHttpSecurityElement Security { get { return default(System.ServiceModel.Configuration.WSDualHttpSecurityElement); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("textEncoding", DefaultValue="utf-8", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("transactionFlow", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool TransactionFlow { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useDefaultWebProxy", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class WSDualHttpSecurityElement : System.Configuration.ConfigurationElement {
    public WSDualHttpSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("message", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.MessageSecurityOverHttpElement Message { get { return default(System.ServiceModel.Configuration.MessageSecurityOverHttpElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("mode", DefaultValue="Message", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.WSDualHttpSecurityMode Mode { get { return default(System.ServiceModel.WSDualHttpSecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public partial class WSFederationHttpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.WSFederationHttpBinding, System.ServiceModel.Configuration.WSFederationHttpBindingElement> {
    public WSFederationHttpBindingCollectionElement() { }
  }
  public partial class WSFederationHttpBindingElement : System.ServiceModel.Configuration.WSHttpBindingBaseElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public WSFederationHttpBindingElement() { }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    [System.Configuration.ConfigurationPropertyAttribute("privacyNoticeAt", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri PrivacyNoticeAt { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("privacyNoticeVersion", DefaultValue="0", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int PrivacyNoticeVersion { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WSFederationHttpSecurityElement Security { get { return default(System.ServiceModel.Configuration.WSFederationHttpSecurityElement); } }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  public sealed partial class WSFederationHttpSecurityElement : System.Configuration.ConfigurationElement {
    public WSFederationHttpSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("message", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.FederatedMessageSecurityOverHttpElement Message { get { return default(System.ServiceModel.Configuration.FederatedMessageSecurityOverHttpElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("mode", DefaultValue="Message", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.WSFederationHttpSecurityMode Mode { get { return default(System.ServiceModel.WSFederationHttpSecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public abstract partial class WSHttpBindingBaseElement : System.ServiceModel.Configuration.StandardBindingElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    protected WSHttpBindingBaseElement() { }
    protected WSHttpBindingBaseElement(string name) { }
    [System.Configuration.ConfigurationPropertyAttribute("bypassProxyOnLocal", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool BypassProxyOnLocal { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue="StrongWildcard", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { return default(System.ServiceModel.HostNameComparisonMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue="524288", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxBufferPoolSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue="65536", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
    public long MaxReceivedMessageSize { get { return default(long); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("messageEncoding", DefaultValue="Text", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.WSMessageEncoding MessageEncoding { get { return default(System.ServiceModel.WSMessageEncoding); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("proxyAddress", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Uri ProxyAddress { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { return default(System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("reliableSession", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.StandardBindingOptionalReliableSessionElement ReliableSession { get { return default(System.ServiceModel.Configuration.StandardBindingOptionalReliableSessionElement); } }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ServiceModel.Configuration.EncodingConverter))]
    [System.Configuration.ConfigurationPropertyAttribute("textEncoding", DefaultValue="utf-8", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Text.Encoding TextEncoding { get { return default(System.Text.Encoding); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("transactionFlow", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool TransactionFlow { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("useDefaultWebProxy", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool UseDefaultWebProxy { get { return default(bool); } set { } }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  [System.MonoTODOAttribute]
  public partial class WSHttpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.WSHttpBinding, System.ServiceModel.Configuration.WSHttpBindingElement> {
    public WSHttpBindingCollectionElement() { }
  }
  public partial class WSHttpBindingElement : System.ServiceModel.Configuration.WSHttpBindingBaseElement, System.ServiceModel.Configuration.IBindingConfigurationElement {
    public WSHttpBindingElement() { }
    public WSHttpBindingElement(string name) { }
    [System.Configuration.ConfigurationPropertyAttribute("allowCookies", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool AllowCookies { get { return default(bool); } set { } }
    protected override System.Type BindingElementType { get { return default(System.Type); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WSHttpSecurityElement Security { get { return default(System.ServiceModel.Configuration.WSHttpSecurityElement); } }
    protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class WSHttpSecurityElement : System.Configuration.ConfigurationElement {
    public WSHttpSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("message", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.NonDualMessageSecurityOverHttpElement Message { get { return default(System.ServiceModel.Configuration.NonDualMessageSecurityOverHttpElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("mode", DefaultValue="Message", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.SecurityMode Mode { get { return default(System.ServiceModel.SecurityMode); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("transport", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.WSHttpTransportSecurityElement Transport { get { return default(System.ServiceModel.Configuration.WSHttpTransportSecurityElement); } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class WSHttpTransportSecurityElement : System.Configuration.ConfigurationElement {
    public WSHttpTransportSecurityElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("clientCredentialType", DefaultValue="Windows", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.HttpClientCredentialType ClientCredentialType { get { return default(System.ServiceModel.HttpClientCredentialType); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("proxyCredentialType", DefaultValue="None", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.HttpProxyCredentialType ProxyCredentialType { get { return default(System.ServiceModel.HttpProxyCredentialType); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("realm", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string Realm { get { return default(string); } set { } }
  }
  public sealed partial class X509CertificateTrustedIssuerElement : System.Configuration.ConfigurationElement {
    public X509CertificateTrustedIssuerElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("findValue", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(4), IsKey=true)]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string FindValue { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("storeLocation", DefaultValue="LocalMachine", Options=(System.Configuration.ConfigurationPropertyOptions)(4), IsKey=true)]
    public System.Security.Cryptography.X509Certificates.StoreLocation StoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("storeName", DefaultValue="My", Options=(System.Configuration.ConfigurationPropertyOptions)(4), IsKey=true)]
    public System.Security.Cryptography.X509Certificates.StoreName StoreName { get { return default(System.Security.Cryptography.X509Certificates.StoreName); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("x509FindType", DefaultValue="FindBySubjectDistinguishedName", Options=(System.Configuration.ConfigurationPropertyOptions)(4), IsKey=true)]
    public System.Security.Cryptography.X509Certificates.X509FindType X509FindType { get { return default(System.Security.Cryptography.X509Certificates.X509FindType); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.X509CertificateTrustedIssuerElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class X509CertificateTrustedIssuerElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.X509CertificateTrustedIssuerElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public X509CertificateTrustedIssuerElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class X509ClientCertificateAuthenticationElement : System.Configuration.ConfigurationElement {
    public X509ClientCertificateAuthenticationElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("certificateValidationMode", DefaultValue="ChainTrust", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { return default(System.ServiceModel.Security.X509CertificateValidationMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("customCertificateValidatorType", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string CustomCertificateValidatorType { get { return default(string); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("includeWindowsGroups", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool IncludeWindowsGroups { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("mapClientCertificateToWindowsAccount", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public bool MapClientCertificateToWindowsAccount { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("revocationMode", DefaultValue="Online", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("trustedStoreLocation", DefaultValue="LocalMachine", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class X509ClientCertificateCredentialsElement : System.Configuration.ConfigurationElement {
    public X509ClientCertificateCredentialsElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("findValue", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string FindValue { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("storeLocation", DefaultValue="LocalMachine", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreLocation StoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("storeName", DefaultValue="My", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreName StoreName { get { return default(System.Security.Cryptography.X509Certificates.StoreName); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("x509FindType", DefaultValue="FindBySubjectDistinguishedName", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.X509FindType X509FindType { get { return default(System.Security.Cryptography.X509Certificates.X509FindType); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class X509DefaultServiceCertificateElement : System.Configuration.ConfigurationElement {
    public X509DefaultServiceCertificateElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("findValue", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string FindValue { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("storeLocation", DefaultValue="CurrentUser", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreLocation StoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("storeName", DefaultValue="My", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreName StoreName { get { return default(System.Security.Cryptography.X509Certificates.StoreName); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("x509FindType", DefaultValue="FindBySubjectDistinguishedName", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.X509FindType X509FindType { get { return default(System.Security.Cryptography.X509Certificates.X509FindType); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class X509InitiatorCertificateClientElement : System.Configuration.ConfigurationElement {
    public X509InitiatorCertificateClientElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("findValue", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string FindValue { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("storeLocation", DefaultValue="CurrentUser", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreLocation StoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("storeName", DefaultValue="My", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreName StoreName { get { return default(System.Security.Cryptography.X509Certificates.StoreName); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("x509FindType", DefaultValue="FindBySubjectDistinguishedName", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.X509FindType X509FindType { get { return default(System.Security.Cryptography.X509Certificates.X509FindType); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class X509InitiatorCertificateServiceElement : System.Configuration.ConfigurationElement {
    public X509InitiatorCertificateServiceElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("authentication", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509ClientCertificateAuthenticationElement Authentication { get { return default(System.ServiceModel.Configuration.X509ClientCertificateAuthenticationElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("certificate", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509ClientCertificateCredentialsElement Certificate { get { return default(System.ServiceModel.Configuration.X509ClientCertificateCredentialsElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class X509PeerCertificateAuthenticationElement : System.Configuration.ConfigurationElement {
    public X509PeerCertificateAuthenticationElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("certificateValidationMode", DefaultValue="PeerOrChainTrust", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { return default(System.ServiceModel.Security.X509CertificateValidationMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("customCertificateValidatorType", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string CustomCertificateValidatorType { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("revocationMode", DefaultValue="Online", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("trustedStoreLocation", DefaultValue="CurrentUser", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class X509PeerCertificateElement : System.Configuration.ConfigurationElement {
    public X509PeerCertificateElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("findValue", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string FindValue { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("storeLocation", DefaultValue="CurrentUser", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreLocation StoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("storeName", DefaultValue="My", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreName StoreName { get { return default(System.Security.Cryptography.X509Certificates.StoreName); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("x509FindType", DefaultValue="FindBySubjectDistinguishedName", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.X509FindType X509FindType { get { return default(System.Security.Cryptography.X509Certificates.X509FindType); } set { } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class X509RecipientCertificateClientElement : System.Configuration.ConfigurationElement {
    public X509RecipientCertificateClientElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("authentication", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509ServiceCertificateAuthenticationElement Authentication { get { return default(System.ServiceModel.Configuration.X509ServiceCertificateAuthenticationElement); } }
    [System.Configuration.ConfigurationPropertyAttribute("defaultCertificate", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509DefaultServiceCertificateElement DefaultCertificate { get { return default(System.ServiceModel.Configuration.X509DefaultServiceCertificateElement); } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("scopedCertificates", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Configuration.X509ScopedServiceCertificateElementCollection ScopedCertificates { get { return default(System.ServiceModel.Configuration.X509ScopedServiceCertificateElementCollection); } }
  }
  [System.MonoTODOAttribute]
  public sealed partial class X509RecipientCertificateServiceElement : System.Configuration.ConfigurationElement {
    public X509RecipientCertificateServiceElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("findValue", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string FindValue { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("storeLocation", DefaultValue="LocalMachine", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreLocation StoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("storeName", DefaultValue="My", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreName StoreName { get { return default(System.Security.Cryptography.X509Certificates.StoreName); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("x509FindType", DefaultValue="FindBySubjectDistinguishedName", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.X509FindType X509FindType { get { return default(System.Security.Cryptography.X509Certificates.X509FindType); } set { } }
  }
  public sealed partial class X509ScopedServiceCertificateElement : System.Configuration.ConfigurationElement {
    public X509ScopedServiceCertificateElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("findValue", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string FindValue { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("storeLocation", DefaultValue="CurrentUser", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreLocation StoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("storeName", DefaultValue="My", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreName StoreName { get { return default(System.Security.Cryptography.X509Certificates.StoreName); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("targetUri", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    public System.Uri TargetUri { get { return default(System.Uri); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("x509FindType", DefaultValue="FindBySubjectDistinguishedName", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.X509FindType X509FindType { get { return default(System.Security.Cryptography.X509Certificates.X509FindType); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.X509ScopedServiceCertificateElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  public sealed partial class X509ScopedServiceCertificateElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.X509ScopedServiceCertificateElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public X509ScopedServiceCertificateElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
  [System.MonoTODOAttribute]
  public sealed partial class X509ServiceCertificateAuthenticationElement : System.Configuration.ConfigurationElement {
    public X509ServiceCertificateAuthenticationElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("certificateValidationMode", DefaultValue="ChainTrust", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { return default(System.ServiceModel.Security.X509CertificateValidationMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("customCertificateValidatorType", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647, InvalidCharacters=null)]
    public string CustomCertificateValidatorType { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("revocationMode", DefaultValue="Online", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("trustedStoreLocation", DefaultValue="CurrentUser", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
  }
  public sealed partial class XmlDictionaryReaderQuotasElement : System.Configuration.ConfigurationElement {
    public XmlDictionaryReaderQuotasElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("maxArrayLength", DefaultValue="0", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxArrayLength { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxBytesPerRead", DefaultValue="0", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxBytesPerRead { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxDepth", DefaultValue="0", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxDepth { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxNameTableCharCount", DefaultValue="0", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxNameTableCharCount { get { return default(int); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("maxStringContentLength", DefaultValue="0", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
    [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=2147483647, ExcludeRange=false)]
    public int MaxStringContentLength { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class XmlElementElement : System.Configuration.ConfigurationElement {
    public XmlElementElement() { }
    public XmlElementElement(System.Xml.XmlElement element) { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("xmlElement", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(4), IsKey=true)]
    public System.Xml.XmlElement XmlElement { get { return default(System.Xml.XmlElement); } set { } }
    protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
    protected override void PostDeserialize() { }
    protected override bool SerializeToXmlElement(System.Xml.XmlWriter writer, string elementName) { return default(bool); }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.XmlElementElement), AddItemName="xmlElement", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
  public sealed partial class XmlElementElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.XmlElementElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public XmlElementElementCollection() { }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    [System.MonoTODOAttribute]
    protected override bool OnDeserializeUnrecognizedElement(string elementName, System.Xml.XmlReader reader) { return default(bool); }
    protected override void Unmerge(System.Configuration.ConfigurationElement sourceElement, System.Configuration.ConfigurationElement parentElement, System.Configuration.ConfigurationSaveMode saveMode) { }
  }
  [System.MonoTODOAttribute]
  public sealed partial class XPathMessageFilterElement : System.Configuration.ConfigurationElement {
    public XPathMessageFilterElement() { }
    [System.Configuration.ConfigurationPropertyAttribute("filter", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6), IsRequired=true, IsKey=true)]
    public System.ServiceModel.Dispatcher.XPathMessageFilter Filter { get { return default(System.ServiceModel.Dispatcher.XPathMessageFilter); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Configuration.XPathMessageFilterElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
  [System.MonoTODOAttribute]
  public sealed partial class XPathMessageFilterElementCollection : System.ServiceModel.Configuration.ServiceModelConfigurationElementCollection<System.ServiceModel.Configuration.XPathMessageFilterElement>, System.Collections.ICollection, System.Collections.IEnumerable {
    public XPathMessageFilterElementCollection() { }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.MonoTODOAttribute]
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
  }
}
namespace System.ServiceModel.Description {
  public partial class CallbackDebugBehavior : System.ServiceModel.Description.IEndpointBehavior {
    public CallbackDebugBehavior(bool includeExceptionDetailInFaults) { }
    public bool IncludeExceptionDetailInFaults { get { return default(bool); } set { } }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher dispatcher) { }
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  public partial class ClientCredentials : System.ServiceModel.Security.SecurityCredentialsManager, System.ServiceModel.Description.IEndpointBehavior {
    public ClientCredentials() { }
    [System.MonoTODOAttribute]
    protected ClientCredentials(System.ServiceModel.Description.ClientCredentials source) { }
    public System.ServiceModel.Security.X509CertificateInitiatorClientCredential ClientCertificate { get { return default(System.ServiceModel.Security.X509CertificateInitiatorClientCredential); } }
    public System.ServiceModel.Security.HttpDigestClientCredential HttpDigest { get { return default(System.ServiceModel.Security.HttpDigestClientCredential); } }
    public System.ServiceModel.Security.IssuedTokenClientCredential IssuedToken { get { return default(System.ServiceModel.Security.IssuedTokenClientCredential); } }
    public System.ServiceModel.Security.PeerCredential Peer { get { return default(System.ServiceModel.Security.PeerCredential); } }
    public System.ServiceModel.Security.X509CertificateRecipientClientCredential ServiceCertificate { get { return default(System.ServiceModel.Security.X509CertificateRecipientClientCredential); } }
    public bool SupportInteractive { get { return default(bool); } set { } }
    public System.ServiceModel.Security.UserNamePasswordClientCredential UserName { get { return default(System.ServiceModel.Security.UserNamePasswordClientCredential); } }
    public System.ServiceModel.Security.WindowsClientCredential Windows { get { return default(System.ServiceModel.Security.WindowsClientCredential); } }
    [System.MonoTODOAttribute]
    public virtual void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior) { }
    public System.ServiceModel.Description.ClientCredentials Clone() { return default(System.ServiceModel.Description.ClientCredentials); }
    protected virtual System.ServiceModel.Description.ClientCredentials CloneCore() { return default(System.ServiceModel.Description.ClientCredentials); }
    public override System.IdentityModel.Selectors.SecurityTokenManager CreateSecurityTokenManager() { return default(System.IdentityModel.Selectors.SecurityTokenManager); }
    [System.MonoTODOAttribute]
    protected virtual System.IdentityModel.Tokens.SecurityToken GetInfoCardSecurityToken(bool requiresInfoCard, System.IdentityModel.Selectors.CardSpacePolicyElement[] chain, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer) { return default(System.IdentityModel.Tokens.SecurityToken); }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher dispatcher) { }
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  public partial class ClientViaBehavior : System.ServiceModel.Description.IEndpointBehavior {
    public ClientViaBehavior(System.Uri uri) { }
    public System.Uri Uri { get { return default(System.Uri); } set { } }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher dispatcher) { }
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={name}, Namespace={ns}, ContractType={contractType}")]
  public partial class ContractDescription {
    public ContractDescription(string name) { }
    public ContractDescription(string name, string ns) { }
    public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IContractBehavior> Behaviors { get { return default(System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IContractBehavior>); } }
    public System.Type CallbackContractType { get { return default(System.Type); } set { } }
    public string ConfigurationName { get { return default(string); } set { } }
    public System.Type ContractType { get { return default(System.Type); } set { } }
    public bool HasProtectionLevel { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.ServiceModel.Description.OperationDescriptionCollection Operations { get { return default(System.ServiceModel.Description.OperationDescriptionCollection); } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public System.ServiceModel.SessionMode SessionMode { get { return default(System.ServiceModel.SessionMode); } set { } }
    public static System.ServiceModel.Description.ContractDescription GetContract(System.Type contractType) { return default(System.ServiceModel.Description.ContractDescription); }
    public static System.ServiceModel.Description.ContractDescription GetContract(System.Type contractType, object serviceImplementation) { return default(System.ServiceModel.Description.ContractDescription); }
    public static System.ServiceModel.Description.ContractDescription GetContract(System.Type contractType, System.Type serviceType) { return default(System.ServiceModel.Description.ContractDescription); }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ContractDescription> GetInheritedContracts() { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ContractDescription>); }
  }
  public partial class DataContractSerializerMessageContractImporter : System.ServiceModel.Description.IWsdlImportExtension {
    public DataContractSerializerMessageContractImporter() { }
    public bool Enabled { get { return default(bool); } set { } }
    void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public partial class DataContractSerializerOperationBehavior : System.ServiceModel.Description.IOperationBehavior, System.ServiceModel.Description.IWsdlExportExtension {
    public DataContractSerializerOperationBehavior(System.ServiceModel.Description.OperationDescription operation) { }
    public DataContractSerializerOperationBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.DataContractFormatAttribute dataContractFormatAttribute) { }
    public System.ServiceModel.DataContractFormatAttribute DataContractFormatAttribute { get { return default(System.ServiceModel.DataContractFormatAttribute); } }
    public System.Runtime.Serialization.IDataContractSurrogate DataContractSurrogate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Runtime.Serialization.IDataContractSurrogate); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IgnoreExtensionDataObject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public int MaxItemsInObjectGraph { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Runtime.Serialization.XmlObjectSerializer CreateSerializer(System.Type type, string name, string ns, System.Collections.Generic.IList<System.Type> knownTypes) { return default(System.Runtime.Serialization.XmlObjectSerializer); }
    public virtual System.Runtime.Serialization.XmlObjectSerializer CreateSerializer(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns, System.Collections.Generic.IList<System.Type> knownTypes) { return default(System.Runtime.Serialization.XmlObjectSerializer); }
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch) { }
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription description) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={name}, Action={action}, DetailType={detailType}")]
  public partial class FaultDescription {
    public FaultDescription(string action) { }
    public string Action { get { return default(string); } }
    public System.Type DetailType { get { return default(System.Type); } set { } }
    public bool HasProtectionLevel { get { return default(bool); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
  }
  public partial class FaultDescriptionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Description.FaultDescription> {
    internal FaultDescriptionCollection() { }
    public System.ServiceModel.Description.FaultDescription Find(string name) { return default(System.ServiceModel.Description.FaultDescription); }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.FaultDescription> FindAll(string name) { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.FaultDescription>); }
  }
  public partial interface IContractBehavior {
    void AddBindingParameters(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters);
    void ApplyClientBehavior(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime proxy);
    void ApplyDispatchBehavior(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.DispatchRuntime dispatch);
    void Validate(System.ServiceModel.Description.ContractDescription description, System.ServiceModel.Description.ServiceEndpoint endpoint);
  }
  public partial interface IContractBehaviorAttribute {
    System.Type TargetContract { get; }
  }
  public partial interface IEndpointBehavior {
    void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters);
    void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior);
    void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.EndpointDispatcher dispatcher);
    void Validate(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint);
  }
  [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/2006/04/mex", Name="IMetadataExchange")]
  public partial interface IMetadataExchange {
    [System.ServiceModel.OperationContractAttribute(ReplyAction="http://schemas.xmlsoap.org/ws/2004/09/transfer/GetResponse", Action="http://schemas.xmlsoap.org/ws/2004/09/transfer/Get", AsyncPattern=true)]
    System.IAsyncResult BeginGet(System.ServiceModel.Channels.Message request, System.AsyncCallback callback, object state);
    System.ServiceModel.Channels.Message EndGet(System.IAsyncResult result);
    [System.ServiceModel.OperationContractAttribute(ReplyAction="http://schemas.xmlsoap.org/ws/2004/09/transfer/GetResponse", Action="http://schemas.xmlsoap.org/ws/2004/09/transfer/Get", AsyncPattern=false)]
    System.ServiceModel.Channels.Message Get(System.ServiceModel.Channels.Message request);
  }
  public partial interface IOperationBehavior {
    void AddBindingParameters(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Channels.BindingParameterCollection parameters);
    void ApplyClientBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy);
    void ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch);
    void Validate(System.ServiceModel.Description.OperationDescription description);
  }
  public partial interface IOperationContractGenerationExtension {
    void GenerateOperation(System.ServiceModel.Description.OperationContractGenerationContext context);
  }
  public partial interface IPolicyExportExtension {
    void ExportPolicy(System.ServiceModel.Description.MetadataExporter exporter, System.ServiceModel.Description.PolicyConversionContext context);
  }
  public partial interface IPolicyImportExtension {
    void ImportPolicy(System.ServiceModel.Description.MetadataImporter importer, System.ServiceModel.Description.PolicyConversionContext context);
  }
  public partial interface IServiceBehavior {
    void AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters);
    void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase);
    void Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase);
  }
  public partial interface IServiceContractGenerationExtension {
    void GenerateContract(System.ServiceModel.Description.ServiceContractGenerationContext context);
  }
  public partial interface IWsdlExportExtension {
    void ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context);
    void ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context);
  }
  public partial interface IWsdlImportExtension {
    void BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy);
    void ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext contractContext);
    void ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext endpointContext);
  }
  public enum ListenUriMode {
    Explicit = 0,
    Unique = 1,
  }
  public partial class MessageBodyDescription {
    public MessageBodyDescription() { }
    public System.ServiceModel.Description.MessagePartDescriptionCollection Parts { get { return default(System.ServiceModel.Description.MessagePartDescriptionCollection); } }
    public System.ServiceModel.Description.MessagePartDescription ReturnValue { get { return default(System.ServiceModel.Description.MessagePartDescription); } set { } }
    public string WrapperName { get { return default(string); } set { } }
    public string WrapperNamespace { get { return default(string); } set { } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Action={action}, Direction={direction}, MessageType={messageType}")]
  public partial class MessageDescription {
    public MessageDescription(string action, System.ServiceModel.Description.MessageDirection direction) { }
    public string Action { get { return default(string); } }
    public System.ServiceModel.Description.MessageBodyDescription Body { get { return default(System.ServiceModel.Description.MessageBodyDescription); } }
    public System.ServiceModel.Description.MessageDirection Direction { get { return default(System.ServiceModel.Description.MessageDirection); } }
    public bool HasProtectionLevel { get { return default(bool); } }
    public System.ServiceModel.Description.MessageHeaderDescriptionCollection Headers { get { return default(System.ServiceModel.Description.MessageHeaderDescriptionCollection); } }
    public System.Type MessageType { get { return default(System.Type); } set { } }
    public System.ServiceModel.Description.MessagePropertyDescriptionCollection Properties { get { return default(System.ServiceModel.Description.MessagePropertyDescriptionCollection); } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
  }
  public partial class MessageDescriptionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MessageDescription> {
    internal MessageDescriptionCollection() { }
    public System.ServiceModel.Description.MessageDescription Find(string action) { return default(System.ServiceModel.Description.MessageDescription); }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MessageDescription> FindAll(string action) { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MessageDescription>); }
  }
  public enum MessageDirection {
    Input = 0,
    Output = 1,
  }
  [System.MonoTODOAttribute]
  public partial class MessageHeaderDescription : System.ServiceModel.Description.MessagePartDescription {
    public MessageHeaderDescription(string name, string ns) : base (default(string), default(string)) { }
    public string Actor { get { return default(string); } set { } }
    public bool MustUnderstand { get { return default(bool); } set { } }
    public bool Relay { get { return default(bool); } set { } }
    public bool TypedHeader { get { return default(bool); } set { } }
  }
  public partial class MessageHeaderDescriptionCollection : System.Collections.ObjectModel.KeyedCollection<System.Xml.XmlQualifiedName, System.ServiceModel.Description.MessageHeaderDescription> {
    internal MessageHeaderDescriptionCollection() { }
    protected override System.Xml.XmlQualifiedName GetKeyForItem(System.ServiceModel.Description.MessageHeaderDescription item) { return default(System.Xml.XmlQualifiedName); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={name}, Namespace={ns}, Type={Type}, Index={index}}")]
  public partial class MessagePartDescription {
    public MessagePartDescription(string name, string ns) { }
    public bool HasProtectionLevel { get { return default(bool); } }
    public int Index { get { return default(int); } set { } }
    public System.Reflection.MemberInfo MemberInfo { get { return default(System.Reflection.MemberInfo); } set { } }
    public bool Multiple { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
    public string Namespace { get { return default(string); } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public System.Type Type { get { return default(System.Type); } set { } }
  }
  public partial class MessagePartDescriptionCollection : System.Collections.ObjectModel.KeyedCollection<System.Xml.XmlQualifiedName, System.ServiceModel.Description.MessagePartDescription> {
    internal MessagePartDescriptionCollection() { }
    protected override System.Xml.XmlQualifiedName GetKeyForItem(System.ServiceModel.Description.MessagePartDescription item) { return default(System.Xml.XmlQualifiedName); }
  }
  [System.MonoTODOAttribute]
  public partial class MessagePropertyDescription : System.ServiceModel.Description.MessagePartDescription {
    public MessagePropertyDescription(string name) : base (default(string), default(string)) { }
  }
  public partial class MessagePropertyDescriptionCollection : System.Collections.ObjectModel.KeyedCollection<System.String, System.ServiceModel.Description.MessagePropertyDescription> {
    internal MessagePropertyDescriptionCollection() { }
    protected override string GetKeyForItem(System.ServiceModel.Description.MessagePropertyDescription item) { return default(string); }
  }
  public partial class MetadataConversionError {
    public MetadataConversionError(string message) { }
    public MetadataConversionError(string message, bool isWarning) { }
    public bool IsWarning { get { return default(bool); } }
    public string Message { get { return default(string); } }
    public override bool Equals(object other) { return default(bool); }
    public override int GetHashCode() { return default(int); }
  }
  public static partial class MetadataExchangeBindings {
    public static System.ServiceModel.Channels.Binding CreateMexHttpBinding() { return default(System.ServiceModel.Channels.Binding); }
    public static System.ServiceModel.Channels.Binding CreateMexHttpsBinding() { return default(System.ServiceModel.Channels.Binding); }
    public static System.ServiceModel.Channels.Binding CreateMexNamedPipeBinding() { return default(System.ServiceModel.Channels.Binding); }
    public static System.ServiceModel.Channels.Binding CreateMexTcpBinding() { return default(System.ServiceModel.Channels.Binding); }
  }
  public partial class MetadataExchangeClient {
    [System.MonoTODOAttribute("use empty configuration")]
    public MetadataExchangeClient() { }
    public MetadataExchangeClient(System.ServiceModel.Channels.Binding mexBinding) { }
    public MetadataExchangeClient(System.ServiceModel.EndpointAddress address) { }
    public MetadataExchangeClient(string endpointConfigurationName) { }
    [System.MonoTODOAttribute("MetadataExchangeClientMode is not considered")]
    public MetadataExchangeClient(System.Uri address, System.ServiceModel.Description.MetadataExchangeClientMode mode) { }
    [System.MonoTODOAttribute]
    public System.Net.ICredentials HttpCredentials { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Net.ICredentials); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public int MaximumResolvedReferences { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(int); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.TimeSpan OperationTimeout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.TimeSpan); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool ResolveMetadataReferences { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Description.ClientCredentials SoapCredentials { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Description.ClientCredentials); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.IAsyncResult BeginGetMetadata(System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginGetMetadata(System.ServiceModel.EndpointAddress address, System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginGetMetadata(System.Uri address, System.ServiceModel.Description.MetadataExchangeClientMode mode, System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public System.ServiceModel.Description.MetadataSet EndGetMetadata(System.IAsyncResult result) { return default(System.ServiceModel.Description.MetadataSet); }
    [System.MonoTODOAttribute("use dialect and identifier (but how?)")]
    protected internal virtual System.ServiceModel.ChannelFactory<System.ServiceModel.Description.IMetadataExchange> GetChannelFactory(System.ServiceModel.EndpointAddress metadataAddress, string dialect, string identifier) { return default(System.ServiceModel.ChannelFactory<System.ServiceModel.Description.IMetadataExchange>); }
    public System.ServiceModel.Description.MetadataSet GetMetadata() { return default(System.ServiceModel.Description.MetadataSet); }
    public System.ServiceModel.Description.MetadataSet GetMetadata(System.ServiceModel.EndpointAddress address) { return default(System.ServiceModel.Description.MetadataSet); }
    public System.ServiceModel.Description.MetadataSet GetMetadata(System.Uri address, System.ServiceModel.Description.MetadataExchangeClientMode mode) { return default(System.ServiceModel.Description.MetadataSet); }
    [System.MonoTODOAttribute]
    protected internal virtual System.Net.HttpWebRequest GetWebRequest(System.Uri location, string dialect, string identifier) { return default(System.Net.HttpWebRequest); }
  }
  public enum MetadataExchangeClientMode {
    HttpGet = 1,
    MetadataExchange = 0,
  }
  [System.MonoTODOAttribute]
  public abstract partial class MetadataExporter {
    internal MetadataExporter() { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MetadataConversionError> Errors { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MetadataConversionError>); } }
    public System.Collections.Generic.Dictionary<System.Object, System.Object> State { get { return default(System.Collections.Generic.Dictionary<System.Object, System.Object>); } }
    public abstract void ExportContract(System.ServiceModel.Description.ContractDescription contract);
    public abstract void ExportEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint);
    protected internal System.ServiceModel.Description.PolicyConversionContext ExportPolicy(System.ServiceModel.Description.ServiceEndpoint endpoint) { return default(System.ServiceModel.Description.PolicyConversionContext); }
    public abstract System.ServiceModel.Description.MetadataSet GetGeneratedMetadata();
  }
  [System.MonoTODOAttribute]
  public abstract partial class MetadataImporter {
    internal MetadataImporter() { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MetadataConversionError> Errors { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MetadataConversionError>); } }
    public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.ServiceModel.Description.ContractDescription> KnownContracts { get { return default(System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, System.ServiceModel.Description.ContractDescription>); } }
    public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IPolicyImportExtension> PolicyImportExtensions { get { return default(System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IPolicyImportExtension>); } }
    public System.Collections.Generic.Dictionary<System.Object, System.Object> State { get { return default(System.Collections.Generic.Dictionary<System.Object, System.Object>); } }
    public abstract System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ContractDescription> ImportAllContracts();
    public abstract System.ServiceModel.Description.ServiceEndpointCollection ImportAllEndpoints();
  }
  [System.MonoTODOAttribute]
  [System.Xml.Serialization.XmlRootAttribute("Location", Namespace="http://schemas.xmlsoap.org/ws/2004/09/mex")]
  public partial class MetadataLocation {
    public MetadataLocation() { }
    public MetadataLocation(string location) { }
    [System.Xml.Serialization.XmlTextAttribute]
    public string Location { get { return default(string); } set { } }
  }
  [System.MonoTODOAttribute]
  [System.Xml.Serialization.XmlRootAttribute("MetadataReference", Namespace="http://schemas.xmlsoap.org/ws/2004/09/mex")]
  public partial class MetadataReference : System.Xml.Serialization.IXmlSerializable {
    public MetadataReference() { }
    public MetadataReference(System.ServiceModel.EndpointAddress address, System.ServiceModel.Channels.AddressingVersion addressVersion) { }
    public System.ServiceModel.EndpointAddress Address { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.AddressingVersion AddressVersion { get { return default(System.ServiceModel.Channels.AddressingVersion); } set { } }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
  }
  [System.MonoTODOAttribute]
  public static partial class MetadataResolver {
    public static System.IAsyncResult BeginResolve(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ContractDescription> contracts, System.ServiceModel.EndpointAddress address, System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginResolve(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ContractDescription> contracts, System.ServiceModel.EndpointAddress address, System.ServiceModel.Description.MetadataExchangeClient client, System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginResolve(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ContractDescription> contracts, System.Uri address, System.ServiceModel.Description.MetadataExchangeClientMode mode, System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginResolve(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ContractDescription> contracts, System.Uri address, System.ServiceModel.Description.MetadataExchangeClientMode mode, System.ServiceModel.Description.MetadataExchangeClient client, System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginResolve(System.Type contract, System.ServiceModel.EndpointAddress address, System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public static System.IAsyncResult BeginResolve(System.Type contract, System.Uri address, System.ServiceModel.Description.MetadataExchangeClientMode mode, System.AsyncCallback callback, object asyncState) { return default(System.IAsyncResult); }
    public static System.ServiceModel.Description.ServiceEndpointCollection EndResolve(System.IAsyncResult result) { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
    public static System.ServiceModel.Description.ServiceEndpointCollection Resolve(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ContractDescription> contracts, System.ServiceModel.EndpointAddress address) { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
    public static System.ServiceModel.Description.ServiceEndpointCollection Resolve(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ContractDescription> contracts, System.ServiceModel.EndpointAddress address, System.ServiceModel.Description.MetadataExchangeClient client) { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
    public static System.ServiceModel.Description.ServiceEndpointCollection Resolve(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ContractDescription> contracts, System.Uri address, System.ServiceModel.Description.MetadataExchangeClientMode mode) { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
    public static System.ServiceModel.Description.ServiceEndpointCollection Resolve(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ContractDescription> contracts, System.Uri address, System.ServiceModel.Description.MetadataExchangeClientMode mode, System.ServiceModel.Description.MetadataExchangeClient client) { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
    public static System.ServiceModel.Description.ServiceEndpointCollection Resolve(System.Type contract, System.ServiceModel.EndpointAddress address) { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
    public static System.ServiceModel.Description.ServiceEndpointCollection Resolve(System.Type contract, System.Uri address, System.ServiceModel.Description.MetadataExchangeClientMode mode) { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
  }
  [System.Xml.Serialization.XmlRootAttribute("MetadataSection", Namespace="http://schemas.xmlsoap.org/ws/2004/09/mex")]
  public partial class MetadataSection {
    public MetadataSection() { }
    public MetadataSection(string dialect, string identifier, object metadata) { }
    [System.Xml.Serialization.XmlAnyAttributeAttribute]
    public System.Collections.ObjectModel.Collection<System.Xml.XmlAttribute> Attributes { get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlAttribute>); } }
    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Dialect { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlAttributeAttribute]
    public string Identifier { get { return default(string); } set { } }
    [System.Xml.Serialization.XmlAnyElementAttribute]
    [System.Xml.Serialization.XmlElementAttribute("definitions", Namespace="http://schemas.xmlsoap.org/wsdl/", Type=typeof(System.Web.Services.Description.ServiceDescription), IsNullable=false)]
    [System.Xml.Serialization.XmlElementAttribute("Location", Namespace="http://schemas.xmlsoap.org/ws/2004/09/mex", Type=typeof(System.ServiceModel.Description.MetadataLocation), IsNullable=false)]
    [System.Xml.Serialization.XmlElementAttribute("Metadata", Namespace="http://schemas.xmlsoap.org/ws/2004/09/mex", Type=typeof(System.ServiceModel.Description.MetadataSet), IsNullable=false)]
    [System.Xml.Serialization.XmlElementAttribute("MetadataReference", Namespace="http://schemas.xmlsoap.org/ws/2004/09/mex", Type=typeof(System.ServiceModel.Description.MetadataReference), IsNullable=false)]
    [System.Xml.Serialization.XmlElementAttribute("schema", Namespace="http://www.w3.org/2001/XMLSchema", Type=typeof(System.Xml.Schema.XmlSchema), IsNullable=false)]
    public object Metadata { get { return default(object); } set { } }
    public static string MetadataExchangeDialect { get { return default(string); } }
    public static string PolicyDialect { get { return default(string); } }
    public static string ServiceDescriptionDialect { get { return default(string); } }
    public static string XmlSchemaDialect { get { return default(string); } }
    public static System.ServiceModel.Description.MetadataSection CreateFromSchema(System.Xml.Schema.XmlSchema schema) { return default(System.ServiceModel.Description.MetadataSection); }
    public static System.ServiceModel.Description.MetadataSection CreateFromServiceDescription(System.Web.Services.Description.ServiceDescription serviceDescription) { return default(System.ServiceModel.Description.MetadataSection); }
  }
  [System.MonoTODOAttribute]
  [System.Xml.Serialization.XmlRootAttribute("Metadata", Namespace="http://schemas.xmlsoap.org/ws/2004/09/mex")]
  public partial class MetadataSet : System.Xml.Serialization.IXmlSerializable {
    public MetadataSet() { }
    public MetadataSet(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.MetadataSection> sections) { }
    [System.Xml.Serialization.XmlAnyAttributeAttribute]
    public System.Collections.ObjectModel.Collection<System.Xml.XmlAttribute> Attributes { get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlAttribute>); } }
    [System.Xml.Serialization.XmlElementAttribute("MetadataSection", Namespace="http://schemas.xmlsoap.org/ws/2004/09/mex")]
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MetadataSection> MetadataSections { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MetadataSection>); } }
    public static System.ServiceModel.Description.MetadataSet ReadFrom(System.Xml.XmlReader reader) { return default(System.ServiceModel.Description.MetadataSet); }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public void WriteTo(System.Xml.XmlWriter writer) { }
  }
  public partial class MustUnderstandBehavior : System.ServiceModel.Description.IEndpointBehavior {
    public MustUnderstandBehavior(bool validate) { }
    public bool ValidateMustUnderstand { get { return default(bool); } set { } }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime proxy) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher dispatcher) { }
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
  }
  [System.MonoTODOAttribute]
  public partial class OperationContractGenerationContext {
    public OperationContractGenerationContext(System.ServiceModel.Description.ServiceContractGenerator serviceContractGenerator, System.ServiceModel.Description.ServiceContractGenerationContext contract, System.ServiceModel.Description.OperationDescription operation, System.CodeDom.CodeTypeDeclaration declaringType, System.CodeDom.CodeMemberMethod method) { }
    public OperationContractGenerationContext(System.ServiceModel.Description.ServiceContractGenerator serviceContractGenerator, System.ServiceModel.Description.ServiceContractGenerationContext contract, System.ServiceModel.Description.OperationDescription operation, System.CodeDom.CodeTypeDeclaration declaringType, System.CodeDom.CodeMemberMethod method, System.CodeDom.CodeMemberMethod beginMethod, System.CodeDom.CodeMemberMethod endMethod) { }
    public System.CodeDom.CodeMemberMethod BeginMethod { get { return default(System.CodeDom.CodeMemberMethod); } }
    public System.ServiceModel.Description.ServiceContractGenerationContext Contract { get { return default(System.ServiceModel.Description.ServiceContractGenerationContext); } }
    public System.CodeDom.CodeTypeDeclaration DeclaringType { get { return default(System.CodeDom.CodeTypeDeclaration); } }
    public System.CodeDom.CodeMemberMethod EndMethod { get { return default(System.CodeDom.CodeMemberMethod); } }
    public bool IsAsync { get { return default(bool); } }
    public System.ServiceModel.Description.OperationDescription Operation { get { return default(System.ServiceModel.Description.OperationDescription); } }
    public System.ServiceModel.Description.ServiceContractGenerator ServiceContractGenerator { get { return default(System.ServiceModel.Description.ServiceContractGenerator); } }
    public System.CodeDom.CodeMemberMethod SyncMethod { get { return default(System.CodeDom.CodeMemberMethod); } }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Name={name}, IsInitiating={isInitiating}, IsTerminating={isTerminating}")]
  public partial class OperationDescription {
    public OperationDescription(string name, System.ServiceModel.Description.ContractDescription declaringContract) { }
    public System.Reflection.MethodInfo BeginMethod { get { return default(System.Reflection.MethodInfo); } set { } }
    public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IOperationBehavior> Behaviors { get { return default(System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IOperationBehavior>); } }
    public System.ServiceModel.Description.ContractDescription DeclaringContract { get { return default(System.ServiceModel.Description.ContractDescription); } set { } }
    public System.Reflection.MethodInfo EndMethod { get { return default(System.Reflection.MethodInfo); } set { } }
    public System.ServiceModel.Description.FaultDescriptionCollection Faults { get { return default(System.ServiceModel.Description.FaultDescriptionCollection); } }
    public bool HasProtectionLevel { get { return default(bool); } }
    public bool IsInitiating { get { return default(bool); } set { } }
    public bool IsOneWay { get { return default(bool); } }
    public bool IsTerminating { get { return default(bool); } set { } }
    public System.Collections.ObjectModel.Collection<System.Type> KnownTypes { get { return default(System.Collections.ObjectModel.Collection<System.Type>); } }
    public System.ServiceModel.Description.MessageDescriptionCollection Messages { get { return default(System.ServiceModel.Description.MessageDescriptionCollection); } }
    public string Name { get { return default(string); } }
    public System.Net.Security.ProtectionLevel ProtectionLevel { get { return default(System.Net.Security.ProtectionLevel); } set { } }
    public System.Reflection.MethodInfo SyncMethod { get { return default(System.Reflection.MethodInfo); } set { } }
  }
  public partial class OperationDescriptionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Description.OperationDescription> {
    internal OperationDescriptionCollection() { }
    public System.ServiceModel.Description.OperationDescription Find(string name) { return default(System.ServiceModel.Description.OperationDescription); }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.OperationDescription> FindAll(string name) { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.OperationDescription>); }
    protected override void InsertItem(int index, System.ServiceModel.Description.OperationDescription item) { }
    protected override void SetItem(int index, System.ServiceModel.Description.OperationDescription item) { }
  }
  public partial class PolicyAssertionCollection : System.Collections.ObjectModel.Collection<System.Xml.XmlElement> {
    public PolicyAssertionCollection() { }
    public PolicyAssertionCollection(System.Collections.Generic.IEnumerable<System.Xml.XmlElement> list) { }
    [System.MonoTODOAttribute]
    public bool Contains(string name, string ns) { return default(bool); }
    [System.MonoTODOAttribute]
    public System.Xml.XmlElement Find(string name, string ns) { return default(System.Xml.XmlElement); }
    [System.MonoTODOAttribute]
    public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> FindAll(string name, string ns) { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlElement>); }
    [System.MonoTODOAttribute]
    protected override void InsertItem(int index, System.Xml.XmlElement item) { }
    [System.MonoTODOAttribute]
    public System.Xml.XmlElement Remove(string name, string ns) { return default(System.Xml.XmlElement); }
    [System.MonoTODOAttribute]
    public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> RemoveAll(string name, string ns) { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlElement>); }
    [System.MonoTODOAttribute]
    protected override void SetItem(int index, System.Xml.XmlElement item) { }
  }
  public abstract partial class PolicyConversionContext {
    protected PolicyConversionContext(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public abstract System.ServiceModel.Channels.BindingElementCollection BindingElements { get; }
    public System.ServiceModel.Description.ContractDescription Contract { get { return default(System.ServiceModel.Description.ContractDescription); } }
    public abstract System.ServiceModel.Description.PolicyAssertionCollection GetBindingAssertions();
    public abstract System.ServiceModel.Description.PolicyAssertionCollection GetFaultBindingAssertions(System.ServiceModel.Description.FaultDescription fault);
    public abstract System.ServiceModel.Description.PolicyAssertionCollection GetMessageBindingAssertions(System.ServiceModel.Description.MessageDescription message);
    public abstract System.ServiceModel.Description.PolicyAssertionCollection GetOperationBindingAssertions(System.ServiceModel.Description.OperationDescription operation);
  }
  public sealed partial class PolicyVersion {
    internal PolicyVersion() { }
    public static System.ServiceModel.Description.PolicyVersion Default { get { return default(System.ServiceModel.Description.PolicyVersion); } }
    public string Namespace { get { return default(string); } }
    public static System.ServiceModel.Description.PolicyVersion Policy12 { get { return default(System.ServiceModel.Description.PolicyVersion); } }
    public static System.ServiceModel.Description.PolicyVersion Policy15 { get { return default(System.ServiceModel.Description.PolicyVersion); } }
    public override string ToString() { return default(string); }
  }
  public enum PrincipalPermissionMode {
    Custom = 3,
    None = 0,
    UseAspNetRoles = 2,
    UseWindowsGroups = 1,
  }
  public sealed partial class ServiceAuthorizationBehavior : System.ServiceModel.Description.IServiceBehavior {
    public ServiceAuthorizationBehavior() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ExternalAuthorizationPolicies { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); } set { } }
    public bool ImpersonateCallerForAllOperations { get { return default(bool); } set { } }
    public System.ServiceModel.Description.PrincipalPermissionMode PrincipalPermissionMode { get { return default(System.ServiceModel.Description.PrincipalPermissionMode); } set { } }
    public System.Web.Security.RoleProvider RoleProvider { get { return default(System.Web.Security.RoleProvider); } set { } }
    public System.ServiceModel.ServiceAuthorizationManager ServiceAuthorizationManager { get { return default(System.ServiceModel.ServiceAuthorizationManager); } set { } }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public partial class ServiceContractGenerationContext {
    public ServiceContractGenerationContext(System.ServiceModel.Description.ServiceContractGenerator serviceContractGenerator, System.ServiceModel.Description.ContractDescription contract, System.CodeDom.CodeTypeDeclaration contractType) { }
    public ServiceContractGenerationContext(System.ServiceModel.Description.ServiceContractGenerator serviceContractGenerator, System.ServiceModel.Description.ContractDescription contract, System.CodeDom.CodeTypeDeclaration contractType, System.CodeDom.CodeTypeDeclaration duplexCallbackType) { }
    public System.ServiceModel.Description.ContractDescription Contract { get { return default(System.ServiceModel.Description.ContractDescription); } }
    public System.CodeDom.CodeTypeDeclaration ContractType { get { return default(System.CodeDom.CodeTypeDeclaration); } }
    public System.CodeDom.CodeTypeDeclaration DuplexCallbackType { get { return default(System.CodeDom.CodeTypeDeclaration); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.OperationContractGenerationContext> Operations { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.OperationContractGenerationContext>); } }
    public System.ServiceModel.Description.ServiceContractGenerator ServiceContractGenerator { get { return default(System.ServiceModel.Description.ServiceContractGenerator); } }
  }
  [System.FlagsAttribute]
  public enum ServiceContractGenerationOptions {
    AsynchronousMethods = 1,
    ChannelInterface = 2,
    ClientClass = 8,
    EventBasedAsynchronousMethods = 32,
    InternalTypes = 4,
    None = 0,
    TypedMessages = 16,
  }
  public partial class ServiceContractGenerator {
    public ServiceContractGenerator() { }
    public ServiceContractGenerator(System.CodeDom.CodeCompileUnit ccu) { }
    public ServiceContractGenerator(System.CodeDom.CodeCompileUnit ccu, System.Configuration.Configuration config) { }
    public ServiceContractGenerator(System.Configuration.Configuration config) { }
    public System.Configuration.Configuration Configuration { get { return default(System.Configuration.Configuration); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MetadataConversionError> Errors { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MetadataConversionError>); } }
    public System.Collections.Generic.Dictionary<System.String, System.String> NamespaceMappings { get { return default(System.Collections.Generic.Dictionary<System.String, System.String>); } }
    public System.ServiceModel.Description.ServiceContractGenerationOptions Options { get { return default(System.ServiceModel.Description.ServiceContractGenerationOptions); } set { } }
    public System.Collections.Generic.Dictionary<System.ServiceModel.Description.ContractDescription, System.Type> ReferencedTypes { get { return default(System.Collections.Generic.Dictionary<System.ServiceModel.Description.ContractDescription, System.Type>); } }
    public System.CodeDom.CodeCompileUnit TargetCompileUnit { get { return default(System.CodeDom.CodeCompileUnit); } }
    public void GenerateBinding(System.ServiceModel.Channels.Binding binding, out string bindingSectionName, out string configurationName) { bindingSectionName = default(string); configurationName = default(string); }
    [System.MonoTODOAttribute]
    public System.CodeDom.CodeTypeReference GenerateServiceContractType(System.ServiceModel.Description.ContractDescription contractDescription) { return default(System.CodeDom.CodeTypeReference); }
    public System.CodeDom.CodeTypeReference GenerateServiceEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint, out System.ServiceModel.Configuration.ChannelEndpointElement channelElement) { channelElement = default(System.ServiceModel.Configuration.ChannelEndpointElement); return default(System.CodeDom.CodeTypeReference); }
  }
  public partial class ServiceCredentials : System.ServiceModel.Security.SecurityCredentialsManager, System.ServiceModel.Description.IServiceBehavior {
    public ServiceCredentials() { }
    protected ServiceCredentials(System.ServiceModel.Description.ServiceCredentials other) { }
    public System.ServiceModel.Security.X509CertificateInitiatorServiceCredential ClientCertificate { get { return default(System.ServiceModel.Security.X509CertificateInitiatorServiceCredential); } }
    public System.ServiceModel.Security.IssuedTokenServiceCredential IssuedTokenAuthentication { get { return default(System.ServiceModel.Security.IssuedTokenServiceCredential); } }
    public System.ServiceModel.Security.PeerCredential Peer { get { return default(System.ServiceModel.Security.PeerCredential); } }
    public System.ServiceModel.Security.SecureConversationServiceCredential SecureConversationAuthentication { get { return default(System.ServiceModel.Security.SecureConversationServiceCredential); } }
    public System.ServiceModel.Security.X509CertificateRecipientServiceCredential ServiceCertificate { get { return default(System.ServiceModel.Security.X509CertificateRecipientServiceCredential); } }
    public System.ServiceModel.Security.UserNamePasswordServiceCredential UserNameAuthentication { get { return default(System.ServiceModel.Security.UserNamePasswordServiceCredential); } }
    public System.ServiceModel.Security.WindowsServiceCredential WindowsAuthentication { get { return default(System.ServiceModel.Security.WindowsServiceCredential); } }
    public System.ServiceModel.Description.ServiceCredentials Clone() { return default(System.ServiceModel.Description.ServiceCredentials); }
    protected virtual System.ServiceModel.Description.ServiceCredentials CloneCore() { return default(System.ServiceModel.Description.ServiceCredentials); }
    public override System.IdentityModel.Selectors.SecurityTokenManager CreateSecurityTokenManager() { return default(System.IdentityModel.Selectors.SecurityTokenManager); }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public partial class ServiceDebugBehavior : System.ServiceModel.Description.IServiceBehavior {
    public ServiceDebugBehavior() { }
    public System.ServiceModel.Channels.Binding HttpHelpPageBinding { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.Binding); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool HttpHelpPageEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Uri HttpHelpPageUrl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Channels.Binding HttpsHelpPageBinding { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.Binding); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool HttpsHelpPageEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Uri HttpsHelpPageUrl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IncludeExceptionDetailInFaults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public partial class ServiceDescription {
    public ServiceDescription() { }
    public ServiceDescription(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ServiceEndpoint> endpoints) { }
    public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IServiceBehavior> Behaviors { get { return default(System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IServiceBehavior>); } }
    public string ConfigurationName { get { return default(string); } set { } }
    public System.ServiceModel.Description.ServiceEndpointCollection Endpoints { get { return default(System.ServiceModel.Description.ServiceEndpointCollection); } }
    public string Name { get { return default(string); } set { } }
    public string Namespace { get { return default(string); } set { } }
    public System.Type ServiceType { get { return default(System.Type); } set { } }
    public static System.ServiceModel.Description.ServiceDescription GetService(object wellKnown) { return default(System.ServiceModel.Description.ServiceDescription); }
    public static System.ServiceModel.Description.ServiceDescription GetService(System.Type type) { return default(System.ServiceModel.Description.ServiceDescription); }
  }
  [System.Diagnostics.DebuggerDisplayAttribute("Address={address}")]
  [System.Diagnostics.DebuggerDisplayAttribute("Name={name}")]
  public partial class ServiceEndpoint {
    public ServiceEndpoint(System.ServiceModel.Description.ContractDescription contract) { }
    public ServiceEndpoint(System.ServiceModel.Description.ContractDescription contract, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) { }
    public System.ServiceModel.EndpointAddress Address { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IEndpointBehavior> Behaviors { get { return default(System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IEndpointBehavior>); } }
    public System.ServiceModel.Channels.Binding Binding { get { return default(System.ServiceModel.Channels.Binding); } set { } }
    public System.ServiceModel.Description.ContractDescription Contract { get { return default(System.ServiceModel.Description.ContractDescription); } }
    public System.Uri ListenUri { get { return default(System.Uri); } set { } }
    public System.ServiceModel.Description.ListenUriMode ListenUriMode { get { return default(System.ServiceModel.Description.ListenUriMode); } set { } }
    public string Name { get { return default(string); } set { } }
  }
  public partial class ServiceEndpointCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> {
    internal ServiceEndpointCollection() { }
    public System.ServiceModel.Description.ServiceEndpoint Find(System.Type type) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint Find(System.Type contractType, System.Xml.XmlQualifiedName bindingName) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint Find(System.Uri uri) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint Find(System.Xml.XmlQualifiedName name) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpoint Find(System.Xml.XmlQualifiedName contractName, System.Xml.XmlQualifiedName bindingName) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> FindAll(System.Type contractType) { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint>); }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> FindAll(System.Xml.XmlQualifiedName name) { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint>); }
    protected override void InsertItem(int index, System.ServiceModel.Description.ServiceEndpoint item) { }
    protected override void SetItem(int index, System.ServiceModel.Description.ServiceEndpoint item) { }
  }
  [System.MonoTODOAttribute]
  public partial class ServiceMetadataBehavior : System.ServiceModel.Description.IServiceBehavior {
    public const string MexContractName = "IMetadataExchange";
    public ServiceMetadataBehavior() { }
    public System.Uri ExternalMetadataLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Channels.Binding HttpGetBinding { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.Binding); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool HttpGetEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Uri HttpGetUrl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Channels.Binding HttpsGetBinding { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.Binding); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool HttpsGetEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Uri HttpsGetUrl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Description.MetadataExporter MetadataExporter { get { return default(System.ServiceModel.Description.MetadataExporter); } set { } }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    [System.MonoTODOAttribute]
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public partial class ServiceMetadataExtension : System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase> {
    public ServiceMetadataExtension() { }
    [System.MonoTODOAttribute]
    public System.ServiceModel.Description.MetadataSet Metadata { get { return default(System.ServiceModel.Description.MetadataSet); } }
    void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Attach(System.ServiceModel.ServiceHostBase owner) { }
    void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Detach(System.ServiceModel.ServiceHostBase owner) { }
  }
  public sealed partial class ServiceSecurityAuditBehavior : System.ServiceModel.Description.IServiceBehavior {
    public ServiceSecurityAuditBehavior() { }
    public System.ServiceModel.AuditLogLocation AuditLogLocation { get { return default(System.ServiceModel.AuditLogLocation); } set { } }
    public System.ServiceModel.AuditLevel MessageAuthenticationAuditLevel { get { return default(System.ServiceModel.AuditLevel); } set { } }
    public System.ServiceModel.AuditLevel ServiceAuthorizationAuditLevel { get { return default(System.ServiceModel.AuditLevel); } set { } }
    public bool SuppressAuditFailure { get { return default(bool); } set { } }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  public partial class ServiceThrottlingBehavior : System.ServiceModel.Description.IServiceBehavior {
    public ServiceThrottlingBehavior() { }
    public int MaxConcurrentCalls { get { return default(int); } set { } }
    public int MaxConcurrentInstances { get { return default(int); } set { } }
    public int MaxConcurrentSessions { get { return default(int); } set { } }
    void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription description, System.ServiceModel.ServiceHostBase serviceHostBase) { }
  }
  [System.MonoTODOAttribute]
  public partial class SynchronousReceiveBehavior : System.ServiceModel.Description.IEndpointBehavior {
    public SynchronousReceiveBehavior() { }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.EndpointDispatcher dispatcher) { }
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint) { }
  }
  [System.MonoTODOAttribute]
  public partial class TransactedBatchingBehavior : System.ServiceModel.Description.IEndpointBehavior {
    public TransactedBatchingBehavior(int maxBatchSize) { }
    public int MaxBatchSize { get { return default(int); } set { } }
    void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior) { }
    void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.EndpointDispatcher dispatcher) { }
    void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint) { }
  }
  public abstract partial class TypedMessageConverter {
    protected TypedMessageConverter() { }
    public static System.ServiceModel.Description.TypedMessageConverter Create(System.Type type, string action) { return default(System.ServiceModel.Description.TypedMessageConverter); }
    public static System.ServiceModel.Description.TypedMessageConverter Create(System.Type type, string action, System.ServiceModel.DataContractFormatAttribute formatterAttribute) { return default(System.ServiceModel.Description.TypedMessageConverter); }
    public static System.ServiceModel.Description.TypedMessageConverter Create(System.Type type, string action, System.ServiceModel.XmlSerializerFormatAttribute formatterAttribute) { return default(System.ServiceModel.Description.TypedMessageConverter); }
    public static System.ServiceModel.Description.TypedMessageConverter Create(System.Type type, string action, string defaultNamespace) { return default(System.ServiceModel.Description.TypedMessageConverter); }
    public static System.ServiceModel.Description.TypedMessageConverter Create(System.Type type, string action, string defaultNamespace, System.ServiceModel.DataContractFormatAttribute formatterAttribute) { return default(System.ServiceModel.Description.TypedMessageConverter); }
    public static System.ServiceModel.Description.TypedMessageConverter Create(System.Type type, string action, string defaultNamespace, System.ServiceModel.XmlSerializerFormatAttribute formatterAttribute) { return default(System.ServiceModel.Description.TypedMessageConverter); }
    public abstract object FromMessage(System.ServiceModel.Channels.Message message);
    public abstract System.ServiceModel.Channels.Message ToMessage(object typedMessage);
    public abstract System.ServiceModel.Channels.Message ToMessage(object typedMessage, System.ServiceModel.Channels.MessageVersion version);
  }
  [System.MonoTODOAttribute]
  public partial class WsdlContractConversionContext {
    internal WsdlContractConversionContext() { }
    public System.ServiceModel.Description.ContractDescription Contract { get { return default(System.ServiceModel.Description.ContractDescription); } }
    public System.Web.Services.Description.PortType WsdlPortType { get { return default(System.Web.Services.Description.PortType); } }
    public System.ServiceModel.Description.MessageDescription GetMessageDescription(System.Web.Services.Description.OperationMessage operationMessage) { return default(System.ServiceModel.Description.MessageDescription); }
    public System.Web.Services.Description.Operation GetOperation(System.ServiceModel.Description.OperationDescription operation) { return default(System.Web.Services.Description.Operation); }
    public System.ServiceModel.Description.OperationDescription GetOperationDescription(System.Web.Services.Description.Operation operation) { return default(System.ServiceModel.Description.OperationDescription); }
    public System.Web.Services.Description.OperationMessage GetOperationMessage(System.ServiceModel.Description.MessageDescription message) { return default(System.Web.Services.Description.OperationMessage); }
  }
  [System.MonoTODOAttribute]
  public partial class WsdlEndpointConversionContext {
    internal WsdlEndpointConversionContext() { }
    public System.ServiceModel.Description.WsdlContractConversionContext ContractConversionContext { get { return default(System.ServiceModel.Description.WsdlContractConversionContext); } }
    public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { return default(System.ServiceModel.Description.ServiceEndpoint); } }
    public System.Web.Services.Description.Binding WsdlBinding { get { return default(System.Web.Services.Description.Binding); } }
    public System.Web.Services.Description.Port WsdlPort { get { return default(System.Web.Services.Description.Port); } }
    public System.Web.Services.Description.MessageBinding GetMessageBinding(System.ServiceModel.Description.MessageDescription message) { return default(System.Web.Services.Description.MessageBinding); }
    public System.ServiceModel.Description.MessageDescription GetMessageDescription(System.Web.Services.Description.MessageBinding message) { return default(System.ServiceModel.Description.MessageDescription); }
    public System.Web.Services.Description.OperationBinding GetOperationBinding(System.ServiceModel.Description.OperationDescription operation) { return default(System.Web.Services.Description.OperationBinding); }
    public System.ServiceModel.Description.OperationDescription GetOperationDescription(System.Web.Services.Description.OperationBinding operation) { return default(System.ServiceModel.Description.OperationDescription); }
  }
  [System.MonoTODOAttribute]
  public partial class WsdlExporter : System.ServiceModel.Description.MetadataExporter {
    public WsdlExporter() { }
    public System.Web.Services.Description.ServiceDescriptionCollection GeneratedWsdlDocuments { get { return default(System.Web.Services.Description.ServiceDescriptionCollection); } }
    public System.Xml.Schema.XmlSchemaSet GeneratedXmlSchemas { get { return default(System.Xml.Schema.XmlSchemaSet); } }
    public override void ExportContract(System.ServiceModel.Description.ContractDescription contract) { }
    public override void ExportEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    public void ExportEndpoints(System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.Xml.XmlQualifiedName name) { }
    public override System.ServiceModel.Description.MetadataSet GetGeneratedMetadata() { return default(System.ServiceModel.Description.MetadataSet); }
  }
  [System.MonoTODOAttribute]
  public partial class WsdlImporter : System.ServiceModel.Description.MetadataImporter {
    public WsdlImporter(System.ServiceModel.Description.MetadataSet metadata) { }
    public WsdlImporter(System.ServiceModel.Description.MetadataSet metadata, System.Collections.Generic.IEnumerable<System.ServiceModel.Description.IPolicyImportExtension> policyImportExtensions, System.Collections.Generic.IEnumerable<System.ServiceModel.Description.IWsdlImportExtension> wsdlImportExtensions) { }
    public System.Web.Services.Description.ServiceDescriptionCollection WsdlDocuments { get { return default(System.Web.Services.Description.ServiceDescriptionCollection); } }
    public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IWsdlImportExtension> WsdlImportExtensions { get { return default(System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IWsdlImportExtension>); } }
    public System.Xml.Schema.XmlSchemaSet XmlSchemas { get { return default(System.Xml.Schema.XmlSchemaSet); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.Binding> ImportAllBindings() { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.Binding>); }
    public override System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ContractDescription> ImportAllContracts() { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ContractDescription>); }
    public override System.ServiceModel.Description.ServiceEndpointCollection ImportAllEndpoints() { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
    public System.ServiceModel.Channels.Binding ImportBinding(System.Web.Services.Description.Binding binding) { return default(System.ServiceModel.Channels.Binding); }
    public System.ServiceModel.Description.ContractDescription ImportContract(System.Web.Services.Description.PortType wsdlPortType) { return default(System.ServiceModel.Description.ContractDescription); }
    public System.ServiceModel.Description.ServiceEndpoint ImportEndpoint(System.Web.Services.Description.Port wsdlPort) { return default(System.ServiceModel.Description.ServiceEndpoint); }
    public System.ServiceModel.Description.ServiceEndpointCollection ImportEndpoints(System.Web.Services.Description.Binding binding) { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
    public System.ServiceModel.Description.ServiceEndpointCollection ImportEndpoints(System.Web.Services.Description.PortType portType) { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
    public System.ServiceModel.Description.ServiceEndpointCollection ImportEndpoints(System.Web.Services.Description.Service service) { return default(System.ServiceModel.Description.ServiceEndpointCollection); }
  }
  public partial class XmlSerializerMessageContractImporter : System.ServiceModel.Description.IWsdlImportExtension {
    public XmlSerializerMessageContractImporter() { }
    public bool Enabled { get { return default(bool); } set { } }
    void System.ServiceModel.Description.IWsdlImportExtension.BeforeImport(System.Web.Services.Description.ServiceDescriptionCollection wsdlDocuments, System.Xml.Schema.XmlSchemaSet xmlSchemas, System.Collections.Generic.ICollection<System.Xml.XmlElement> policy) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportContract(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlImportExtension.ImportEndpoint(System.ServiceModel.Description.WsdlImporter importer, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
  public partial class XmlSerializerOperationBehavior : System.ServiceModel.Description.IOperationBehavior, System.ServiceModel.Description.IWsdlExportExtension {
    public XmlSerializerOperationBehavior(System.ServiceModel.Description.OperationDescription operation) { }
    public XmlSerializerOperationBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.XmlSerializerFormatAttribute format) { }
    public System.ServiceModel.XmlSerializerFormatAttribute XmlSerializerFormatAttribute { get { return default(System.ServiceModel.XmlSerializerFormatAttribute); } }
    [System.MonoTODOAttribute]
    public System.Collections.ObjectModel.Collection<System.Xml.Serialization.XmlMapping> GetXmlMappings() { return default(System.Collections.ObjectModel.Collection<System.Xml.Serialization.XmlMapping>); }
    void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy) { }
    void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch) { }
    void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription description) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
    void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
  }
}
namespace System.ServiceModel.Diagnostics {
  public enum PerformanceCounterScope {
    All = 2,
    Off = 0,
    ServiceOnly = 1,
  }
}
namespace System.ServiceModel.Dispatcher {
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class ActionMessageFilter : System.ServiceModel.Dispatcher.MessageFilter {
    public ActionMessageFilter(params System.String[] actions) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> Actions { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
    protected internal override System.ServiceModel.Dispatcher.IMessageFilterTable<FilterData> CreateFilterTable<FilterData>() { return default(System.ServiceModel.Dispatcher.IMessageFilterTable<FilterData>); }
    public override bool Match(System.ServiceModel.Channels.Message message) { return default(bool); }
    public override bool Match(System.ServiceModel.Channels.MessageBuffer buffer) { return default(bool); }
  }
  public partial class ChannelDispatcher : System.ServiceModel.Dispatcher.ChannelDispatcherBase {
    [System.MonoTODOAttribute("get binding info from config")]
    public ChannelDispatcher(System.ServiceModel.Channels.IChannelListener listener) { }
    public ChannelDispatcher(System.ServiceModel.Channels.IChannelListener listener, string bindingName) { }
    public ChannelDispatcher(System.ServiceModel.Channels.IChannelListener listener, string bindingName, System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
    public string BindingName { get { return default(string); } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IChannelInitializer> ChannelInitializers { get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IChannelInitializer>); } }
    protected internal override System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    protected internal override System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.EndpointDispatcher> Endpoints { get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.EndpointDispatcher>); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.IErrorHandler> ErrorHandlers { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.IErrorHandler>); } }
    public override System.ServiceModel.ServiceHostBase Host { get { return default(System.ServiceModel.ServiceHostBase); } }
    public bool IncludeExceptionDetailInFaults { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public bool IsTransactedAccept { get { return default(bool); } }
    public bool IsTransactedReceive { get { return default(bool); } set { } }
    public override System.ServiceModel.Channels.IChannelListener Listener { get { return default(System.ServiceModel.Channels.IChannelListener); } }
    public bool ManualAddressing { get { return default(bool); } set { } }
    public int MaxTransactedBatchSize { get { return default(int); } set { } }
    public System.ServiceModel.Channels.MessageVersion MessageVersion { get { return default(System.ServiceModel.Channels.MessageVersion); } set { } }
    public bool ReceiveSynchronously { get { return default(bool); } set { } }
    public System.ServiceModel.Dispatcher.ServiceThrottle ServiceThrottle { get { return default(System.ServiceModel.Dispatcher.ServiceThrottle); } set { } }
    public System.Transactions.IsolationLevel TransactionIsolationLevel { get { return default(System.Transactions.IsolationLevel); } set { } }
    public System.TimeSpan TransactionTimeout { get { return default(System.TimeSpan); } set { } }
    protected internal override void Attach(System.ServiceModel.ServiceHostBase host) { }
    public override void CloseInput() { }
    protected internal override void Detach(System.ServiceModel.ServiceHostBase host) { }
    protected override void OnAbort() { }
    protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    protected override void OnClose(System.TimeSpan timeout) { }
    protected override void OnClosed() { }
    protected override void OnEndClose(System.IAsyncResult result) { }
    protected override void OnEndOpen(System.IAsyncResult result) { }
    protected override void OnOpen(System.TimeSpan timeout) { }
    protected override void OnOpened() { }
    protected override void OnOpening() { }
  }
  public abstract partial class ChannelDispatcherBase : System.ServiceModel.Channels.CommunicationObject {
    protected ChannelDispatcherBase() { }
    public abstract System.ServiceModel.ServiceHostBase Host { get; }
    public abstract System.ServiceModel.Channels.IChannelListener Listener { get; }
    protected internal virtual void Attach(System.ServiceModel.ServiceHostBase host) { }
    public virtual void CloseInput() { }
    protected internal virtual void Detach(System.ServiceModel.ServiceHostBase host) { }
  }
  public partial class ChannelDispatcherCollection : System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.ChannelDispatcherBase> {
    internal ChannelDispatcherCollection() { }
    protected override void ClearItems() { }
    protected override void InsertItem(int index, System.ServiceModel.Dispatcher.ChannelDispatcherBase item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.ServiceModel.Dispatcher.ChannelDispatcherBase item) { }
  }
  public sealed partial class ClientOperation {
    public ClientOperation(System.ServiceModel.Dispatcher.ClientRuntime parent, string name, string action) { }
    public ClientOperation(System.ServiceModel.Dispatcher.ClientRuntime parent, string name, string action, string replyAction) { }
    public string Action { get { return default(string); } }
    public System.Reflection.MethodInfo BeginMethod { get { return default(System.Reflection.MethodInfo); } set { } }
    public bool DeserializeReply { get { return default(bool); } set { } }
    public System.Reflection.MethodInfo EndMethod { get { return default(System.Reflection.MethodInfo); } set { } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.FaultContractInfo> FaultContractInfos { get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.FaultContractInfo>); } }
    public System.ServiceModel.Dispatcher.IClientMessageFormatter Formatter { get { return default(System.ServiceModel.Dispatcher.IClientMessageFormatter); } set { } }
    public bool IsInitiating { get { return default(bool); } set { } }
    public bool IsOneWay { get { return default(bool); } set { } }
    public bool IsTerminating { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IParameterInspector> ParameterInspectors { get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IParameterInspector>); } }
    public System.ServiceModel.Dispatcher.ClientRuntime Parent { get { return default(System.ServiceModel.Dispatcher.ClientRuntime); } }
    public string ReplyAction { get { return default(string); } }
    public bool SerializeRequest { get { return default(bool); } set { } }
    public System.Reflection.MethodInfo SyncMethod { get { return default(System.Reflection.MethodInfo); } set { } }
  }
  public sealed partial class ClientRuntime {
    internal ClientRuntime() { }
    public System.Type CallbackClientType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Dispatcher.DispatchRuntime CallbackDispatchRuntime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Dispatcher.DispatchRuntime); } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IChannelInitializer> ChannelInitializers { get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IChannelInitializer>); } }
    public System.Type ContractClientType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string ContractName { get { return default(string); } }
    public string ContractNamespace { get { return default(string); } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IInteractiveChannelInitializer> InteractiveChannelInitializers { get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IInteractiveChannelInitializer>); } }
    public bool ManualAddressing { get { return default(bool); } set { } }
    public int MaxFaultSize { get { return default(int); } set { } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IClientMessageInspector> MessageInspectors { get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IClientMessageInspector>); } }
    [System.MonoTODOAttribute]
    public bool MessageVersionNoneFaultsEnabled { get { return default(bool); } set { } }
    public System.Collections.Generic.SynchronizedKeyedCollection<System.String, System.ServiceModel.Dispatcher.ClientOperation> Operations { get { return default(System.Collections.Generic.SynchronizedKeyedCollection<System.String, System.ServiceModel.Dispatcher.ClientOperation>); } }
    public System.ServiceModel.Dispatcher.IClientOperationSelector OperationSelector { get { return default(System.ServiceModel.Dispatcher.IClientOperationSelector); } set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.Dispatcher.ClientOperation UnhandledClientOperation { get { return default(System.ServiceModel.Dispatcher.ClientOperation); } }
    public bool ValidateMustUnderstand { get { return default(bool); } set { } }
    public System.Uri Via { get { return default(System.Uri); } set { } }
  }
  public sealed partial class DispatchOperation {
    public DispatchOperation(System.ServiceModel.Dispatcher.DispatchRuntime parent, string name, string action) { }
    public DispatchOperation(System.ServiceModel.Dispatcher.DispatchRuntime parent, string name, string action, string replyAction) { }
    public string Action { get { return default(string); } }
    public bool AutoDisposeParameters { get { return default(bool); } set { } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.ICallContextInitializer> CallContextInitializers { get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.ICallContextInitializer>); } }
    public bool DeserializeRequest { get { return default(bool); } set { } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.FaultContractInfo> FaultContractInfos { get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.FaultContractInfo>); } }
    public System.ServiceModel.Dispatcher.IDispatchMessageFormatter Formatter { get { return default(System.ServiceModel.Dispatcher.IDispatchMessageFormatter); } set { } }
    [System.MonoTODOAttribute("not considered")]
    public System.ServiceModel.ImpersonationOption Impersonation { get { return default(System.ServiceModel.ImpersonationOption); } set { } }
    public System.ServiceModel.Dispatcher.IOperationInvoker Invoker { get { return default(System.ServiceModel.Dispatcher.IOperationInvoker); } set { } }
    public bool IsOneWay { get { return default(bool); } }
    public bool IsTerminating { get { return default(bool); } set { } }
    public string Name { get { return default(string); } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IParameterInspector> ParameterInspectors { get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IParameterInspector>); } }
    public System.ServiceModel.Dispatcher.DispatchRuntime Parent { get { return default(System.ServiceModel.Dispatcher.DispatchRuntime); } }
    public bool ReleaseInstanceAfterCall { get { return default(bool); } set { } }
    public bool ReleaseInstanceBeforeCall { get { return default(bool); } set { } }
    public string ReplyAction { get { return default(string); } }
    public bool SerializeReply { get { return default(bool); } set { } }
    public bool TransactionAutoComplete { get { return default(bool); } set { } }
    public bool TransactionRequired { get { return default(bool); } set { } }
  }
  public sealed partial class DispatchRuntime {
    internal DispatchRuntime() { }
    [System.MonoTODOAttribute]
    public bool AutomaticInputSessionShutdown { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Dispatcher.ClientRuntime CallbackClientRuntime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Dispatcher.ClientRuntime); } }
    public System.ServiceModel.Dispatcher.ChannelDispatcher ChannelDispatcher { get { return default(System.ServiceModel.Dispatcher.ChannelDispatcher); } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.ConcurrencyMode ConcurrencyMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.ConcurrencyMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Dispatcher.EndpointDispatcher EndpointDispatcher { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Dispatcher.EndpointDispatcher); } }
    [System.MonoTODOAttribute]
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ExternalAuthorizationPolicies { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool IgnoreTransactionMessageProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool ImpersonateCallerForAllOperations { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IInputSessionShutdown> InputSessionShutdownHandlers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IInputSessionShutdown>); } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IInstanceContextInitializer> InstanceContextInitializers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IInstanceContextInitializer>); } }
    public System.ServiceModel.Dispatcher.IInstanceContextProvider InstanceContextProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Dispatcher.IInstanceContextProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Dispatcher.IInstanceProvider InstanceProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Dispatcher.IInstanceProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.AuditLevel MessageAuthenticationAuditLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.AuditLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IDispatchMessageInspector> MessageInspectors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IDispatchMessageInspector>); } }
    public System.Collections.Generic.SynchronizedKeyedCollection<System.String, System.ServiceModel.Dispatcher.DispatchOperation> Operations { get { return default(System.Collections.Generic.SynchronizedKeyedCollection<System.String, System.ServiceModel.Dispatcher.DispatchOperation>); } }
    public System.ServiceModel.Dispatcher.IDispatchOperationSelector OperationSelector { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Dispatcher.IDispatchOperationSelector); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.Description.PrincipalPermissionMode PrincipalPermissionMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Description.PrincipalPermissionMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool ReleaseServiceInstanceOnTransactionComplete { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Web.Security.RoleProvider RoleProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.Security.RoleProvider); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.AuditLogLocation SecurityAuditLogLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.AuditLogLocation); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.AuditLevel ServiceAuthorizationAuditLevel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.AuditLevel); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.ServiceAuthorizationManager ServiceAuthorizationManager { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.ServiceAuthorizationManager); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.InstanceContext SingletonInstanceContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.InstanceContext); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool SuppressAuditFailure { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.Threading.SynchronizationContext SynchronizationContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Threading.SynchronizationContext); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public bool TransactionAutoCompleteOnSessionClose { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Dispatcher.DispatchOperation UnhandledDispatchOperation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Dispatcher.DispatchOperation); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool ValidateMustUnderstand { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class EndpointAddressMessageFilter : System.ServiceModel.Dispatcher.MessageFilter {
    public EndpointAddressMessageFilter(System.ServiceModel.EndpointAddress address) { }
    public EndpointAddressMessageFilter(System.ServiceModel.EndpointAddress address, bool includeHostNameInComparison) { }
    public System.ServiceModel.EndpointAddress Address { get { return default(System.ServiceModel.EndpointAddress); } }
    public bool IncludeHostNameInComparison { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Dispatcher.IMessageFilterTable<FilterData> CreateFilterTable<FilterData>() { return default(System.ServiceModel.Dispatcher.IMessageFilterTable<FilterData>); }
    public override bool Match(System.ServiceModel.Channels.Message message) { return default(bool); }
    public override bool Match(System.ServiceModel.Channels.MessageBuffer messageBuffer) { return default(bool); }
  }
  public partial class EndpointDispatcher {
    public EndpointDispatcher(System.ServiceModel.EndpointAddress address, string contractName, string contractNamespace) { }
    public System.ServiceModel.Dispatcher.MessageFilter AddressFilter { get { return default(System.ServiceModel.Dispatcher.MessageFilter); } set { } }
    public System.ServiceModel.Dispatcher.ChannelDispatcher ChannelDispatcher { get { return default(System.ServiceModel.Dispatcher.ChannelDispatcher); } }
    public System.ServiceModel.Dispatcher.MessageFilter ContractFilter { get { return default(System.ServiceModel.Dispatcher.MessageFilter); } set { } }
    public string ContractName { get { return default(string); } }
    public string ContractNamespace { get { return default(string); } }
    public System.ServiceModel.Dispatcher.DispatchRuntime DispatchRuntime { get { return default(System.ServiceModel.Dispatcher.DispatchRuntime); } }
    public System.ServiceModel.EndpointAddress EndpointAddress { get { return default(System.ServiceModel.EndpointAddress); } }
    public int FilterPriority { get { return default(int); } set { } }
  }
  public abstract partial class ExceptionHandler {
    protected ExceptionHandler() { }
    public static System.ServiceModel.Dispatcher.ExceptionHandler AlwaysHandle { get { return default(System.ServiceModel.Dispatcher.ExceptionHandler); } }
    public static System.ServiceModel.Dispatcher.ExceptionHandler AsynchronousThreadExceptionHandler { [System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(3), (System.Runtime.ConstrainedExecution.Cer)(2))]get { return default(System.ServiceModel.Dispatcher.ExceptionHandler); } set { } }
    public static System.ServiceModel.Dispatcher.ExceptionHandler TransportExceptionHandler { get { return default(System.ServiceModel.Dispatcher.ExceptionHandler); } set { } }
    public abstract bool HandleException(System.Exception e);
  }
  public partial class FaultContractInfo {
    public FaultContractInfo(string action, System.Type detail) { }
    public string Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public System.Type Detail { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Type); } }
  }
  public partial class FilterInvalidBodyAccessException : System.ServiceModel.Dispatcher.InvalidBodyAccessException {
    public FilterInvalidBodyAccessException() : base (default(string)) { }
    protected FilterInvalidBodyAccessException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base (default(string)) { }
    public FilterInvalidBodyAccessException(string msg) : base (default(string)) { }
    public FilterInvalidBodyAccessException(string msg, System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter> filters) : base (default(string)) { }
    public FilterInvalidBodyAccessException(string msg, System.Exception inner) : base (default(string)) { }
    public FilterInvalidBodyAccessException(string msg, System.Exception inner, System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter> filters) : base (default(string)) { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter> Filters { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter>); } }
  }
  public partial interface ICallContextInitializer {
    void AfterInvoke(object correlationState);
    object BeforeInvoke(System.ServiceModel.InstanceContext instanceContext, System.ServiceModel.IClientChannel channel, System.ServiceModel.Channels.Message message);
  }
  public partial interface IChannelInitializer {
    void Initialize(System.ServiceModel.IClientChannel channel);
  }
  public partial interface IClientMessageFormatter {
    object DeserializeReply(System.ServiceModel.Channels.Message message, System.Object[] paremeters);
    System.ServiceModel.Channels.Message SerializeRequest(System.ServiceModel.Channels.MessageVersion version, System.Object[] inputs);
  }
  public partial interface IClientMessageInspector {
    void AfterReceiveReply(ref System.ServiceModel.Channels.Message message, object correlationState);
    object BeforeSendRequest(ref System.ServiceModel.Channels.Message message, System.ServiceModel.IClientChannel channel);
  }
  public partial interface IClientOperationSelector {
    bool AreParametersRequiredForSelection { get; }
    string SelectOperation(System.Reflection.MethodBase method, System.Object[] parameters);
  }
  public partial interface IDispatchMessageFormatter {
    void DeserializeRequest(System.ServiceModel.Channels.Message message, System.Object[] parameters);
    System.ServiceModel.Channels.Message SerializeReply(System.ServiceModel.Channels.MessageVersion version, System.Object[] parameters, object result);
  }
  public partial interface IDispatchMessageInspector {
    object AfterReceiveRequest(ref System.ServiceModel.Channels.Message message, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext context);
    void BeforeSendReply(ref System.ServiceModel.Channels.Message message, object instance);
  }
  public partial interface IDispatchOperationSelector {
    string SelectOperation(ref System.ServiceModel.Channels.Message msg);
  }
  public partial interface IErrorHandler {
    bool HandleError(System.Exception exception);
    void ProvideFault(System.Exception exception, System.ServiceModel.Channels.MessageVersion version, ref System.ServiceModel.Channels.Message fault);
  }
  public partial interface IInputSessionShutdown {
    void ChannelFaulted(System.ServiceModel.IDuplexContextChannel channel);
    void DoneReceiving(System.ServiceModel.IDuplexContextChannel channel);
  }
  public partial interface IInstanceContextInitializer {
    void Initialize(System.ServiceModel.InstanceContext context, System.ServiceModel.Channels.Message message);
  }
  public partial interface IInstanceContextProvider {
    System.ServiceModel.InstanceContext GetExistingInstanceContext(System.ServiceModel.Channels.Message message, System.ServiceModel.IContextChannel channel);
    void InitializeInstanceContext(System.ServiceModel.InstanceContext instanceContext, System.ServiceModel.Channels.Message message, System.ServiceModel.IContextChannel channel);
    bool IsIdle(System.ServiceModel.InstanceContext instanceContext);
    void NotifyIdle(System.ServiceModel.Dispatcher.InstanceContextIdleCallback callback, System.ServiceModel.InstanceContext instanceContext);
  }
  public partial interface IInstanceProvider {
    object GetInstance(System.ServiceModel.InstanceContext context);
    object GetInstance(System.ServiceModel.InstanceContext context, System.ServiceModel.Channels.Message message);
    void ReleaseInstance(System.ServiceModel.InstanceContext context, object instance);
  }
  public partial interface IInteractiveChannelInitializer {
    System.IAsyncResult BeginDisplayInitializationUI(System.ServiceModel.IClientChannel channel, System.AsyncCallback callback, object state);
    void EndDisplayInitializationUI(System.IAsyncResult result);
  }
  public partial interface IMessageFilterTable<TFilterData> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>>, System.Collections.Generic.IDictionary<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>>, System.Collections.IEnumerable {
    bool GetMatchingFilter(System.ServiceModel.Channels.Message message, out System.ServiceModel.Dispatcher.MessageFilter result);
    bool GetMatchingFilter(System.ServiceModel.Channels.MessageBuffer buffer, out System.ServiceModel.Dispatcher.MessageFilter result);
    bool GetMatchingFilters(System.ServiceModel.Channels.Message message, System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter> results);
    bool GetMatchingFilters(System.ServiceModel.Channels.MessageBuffer buffer, System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter> results);
    bool GetMatchingValue(System.ServiceModel.Channels.Message message, out TFilterData data);
    bool GetMatchingValue(System.ServiceModel.Channels.MessageBuffer buffer, out TFilterData data);
    bool GetMatchingValues(System.ServiceModel.Channels.Message message, System.Collections.Generic.ICollection<TFilterData> results);
    bool GetMatchingValues(System.ServiceModel.Channels.MessageBuffer buffer, System.Collections.Generic.ICollection<TFilterData> results);
  }
  public delegate void InstanceContextIdleCallback(System.ServiceModel.InstanceContext context);
  public abstract partial class InvalidBodyAccessException : System.SystemException {
    protected InvalidBodyAccessException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    protected InvalidBodyAccessException(string msg) { }
    protected InvalidBodyAccessException(string msg, System.Exception inner) { }
  }
  public partial interface IOperationInvoker {
    bool IsSynchronous { get; }
    System.Object[] AllocateInputs();
    object Invoke(object instance, System.Object[] inputs, out System.Object[] outputs);
    System.IAsyncResult InvokeBegin(object instance, System.Object[] inputs, System.AsyncCallback callback, object state);
    object InvokeEnd(object instance, out System.Object[] outputs, System.IAsyncResult result);
  }
  public partial interface IParameterInspector {
    void AfterCall(string operationName, System.Object[] outputs, object returnValue, object correlationState);
    object BeforeCall(string operationName, System.Object[] inputs);
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class MatchAllMessageFilter : System.ServiceModel.Dispatcher.MessageFilter {
    public MatchAllMessageFilter() { }
    public override bool Match(System.ServiceModel.Channels.Message message) { return default(bool); }
    public override bool Match(System.ServiceModel.Channels.MessageBuffer buffer) { return default(bool); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class MatchNoneMessageFilter : System.ServiceModel.Dispatcher.MessageFilter {
    public MatchNoneMessageFilter() { }
    public override bool Match(System.ServiceModel.Channels.Message message) { return default(bool); }
    public override bool Match(System.ServiceModel.Channels.MessageBuffer buffer) { return default(bool); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.ServiceModel.Dispatcher.ActionMessageFilter))]
  [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.ServiceModel.Dispatcher.MatchAllMessageFilter))]
  [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.ServiceModel.Dispatcher.MatchNoneMessageFilter))]
  [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.ServiceModel.Dispatcher.XPathMessageFilter))]
  public abstract partial class MessageFilter {
    protected MessageFilter() { }
    protected internal virtual System.ServiceModel.Dispatcher.IMessageFilterTable<FilterData> CreateFilterTable<FilterData>() { return default(System.ServiceModel.Dispatcher.IMessageFilterTable<FilterData>); }
    public abstract bool Match(System.ServiceModel.Channels.Message message);
    public abstract bool Match(System.ServiceModel.Channels.MessageBuffer buffer);
  }
  public partial class MessageFilterException : System.ServiceModel.CommunicationException {
    public MessageFilterException() { }
    protected MessageFilterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MessageFilterException(string msg) { }
    public MessageFilterException(string msg, System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter> filters) { }
    public MessageFilterException(string msg, System.Exception inner) { }
    public MessageFilterException(string msg, System.Exception inner, System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter> filters) { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter> Filters { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter>); } }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class MessageFilterTable<TFilterData> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>>, System.Collections.Generic.IDictionary<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>>, System.Collections.IEnumerable, System.ServiceModel.Dispatcher.IMessageFilterTable<TFilterData> {
    public MessageFilterTable() { }
    public MessageFilterTable(int default_priority) { }
    public int Count { get { return default(int); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public int DefaultPriority { get { return default(int); } set { } }
    public bool IsReadOnly { get { return default(bool); } }
    public TFilterData this[System.ServiceModel.Dispatcher.MessageFilter filter] { get { return default(TFilterData); } set { } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter> Keys { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter>); } }
    public System.Collections.Generic.ICollection<TFilterData> Values { get { return default(System.Collections.Generic.ICollection<TFilterData>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData> item) { }
    public void Add(System.ServiceModel.Dispatcher.MessageFilter filter, TFilterData data) { }
    public void Add(System.ServiceModel.Dispatcher.MessageFilter filter, TFilterData data, int priority) { }
    public void Clear() { }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData> item) { return default(bool); }
    public bool ContainsKey(System.ServiceModel.Dispatcher.MessageFilter filter) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>[] array, int index) { }
    protected virtual System.ServiceModel.Dispatcher.IMessageFilterTable<TFilterData> CreateFilterTable(System.ServiceModel.Dispatcher.MessageFilter filter) { return default(System.ServiceModel.Dispatcher.IMessageFilterTable<TFilterData>); }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>>); }
    public bool GetMatchingFilter(System.ServiceModel.Channels.Message message, out System.ServiceModel.Dispatcher.MessageFilter result) { result = default(System.ServiceModel.Dispatcher.MessageFilter); return default(bool); }
    public bool GetMatchingFilter(System.ServiceModel.Channels.MessageBuffer buffer, out System.ServiceModel.Dispatcher.MessageFilter result) { result = default(System.ServiceModel.Dispatcher.MessageFilter); return default(bool); }
    [System.MonoTODOAttribute("Consider priority")]
    public bool GetMatchingFilters(System.ServiceModel.Channels.Message message, System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter> results) { return default(bool); }
    public bool GetMatchingFilters(System.ServiceModel.Channels.MessageBuffer buffer, System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter> results) { return default(bool); }
    [System.MonoTODOAttribute("Consider priority")]
    public bool GetMatchingValue(System.ServiceModel.Channels.Message message, out TFilterData data) { data = default(TFilterData); return default(bool); }
    public bool GetMatchingValue(System.ServiceModel.Channels.MessageBuffer buffer, out TFilterData data) { data = default(TFilterData); return default(bool); }
    public bool GetMatchingValues(System.ServiceModel.Channels.Message message, System.Collections.Generic.ICollection<TFilterData> results) { return default(bool); }
    public bool GetMatchingValues(System.ServiceModel.Channels.MessageBuffer buffer, System.Collections.Generic.ICollection<TFilterData> results) { return default(bool); }
    public int GetPriority(System.ServiceModel.Dispatcher.MessageFilter filter) { return default(int); }
    public bool Remove(System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData> item) { return default(bool); }
    public bool Remove(System.ServiceModel.Dispatcher.MessageFilter filter) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public bool TryGetValue(System.ServiceModel.Dispatcher.MessageFilter filter, out TFilterData data) { data = default(TFilterData); return default(bool); }
  }
  public partial class MultipleFilterMatchesException : System.SystemException {
    public MultipleFilterMatchesException() { }
    protected MultipleFilterMatchesException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MultipleFilterMatchesException(string msg) { }
    public MultipleFilterMatchesException(string msg, System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter> filters) { }
    public MultipleFilterMatchesException(string msg, System.Exception inner) { }
    public MultipleFilterMatchesException(string msg, System.Exception inner, System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter> filters) { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter> Filters { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Dispatcher.MessageFilter>); } }
  }
  public partial class NavigatorInvalidBodyAccessException : System.ServiceModel.Dispatcher.InvalidBodyAccessException {
    public NavigatorInvalidBodyAccessException() : base (default(string)) { }
    protected NavigatorInvalidBodyAccessException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base (default(string)) { }
    public NavigatorInvalidBodyAccessException(string msg) : base (default(string)) { }
    public NavigatorInvalidBodyAccessException(string msg, System.Exception inner) : base (default(string)) { }
  }
  public partial class PrefixEndpointAddressMessageFilter : System.ServiceModel.Dispatcher.MessageFilter {
    public PrefixEndpointAddressMessageFilter(System.ServiceModel.EndpointAddress address) { }
    public PrefixEndpointAddressMessageFilter(System.ServiceModel.EndpointAddress address, bool includeHostNameInComparison) { }
    public System.ServiceModel.EndpointAddress Address { get { return default(System.ServiceModel.EndpointAddress); } }
    public bool IncludeHostNameInComparison { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected internal override System.ServiceModel.Dispatcher.IMessageFilterTable<FilterData> CreateFilterTable<FilterData>() { return default(System.ServiceModel.Dispatcher.IMessageFilterTable<FilterData>); }
    [System.MonoTODOAttribute]
    public override bool Match(System.ServiceModel.Channels.Message message) { return default(bool); }
    public override bool Match(System.ServiceModel.Channels.MessageBuffer messageBuffer) { return default(bool); }
  }
  public abstract partial class SeekableXPathNavigator : System.Xml.XPath.XPathNavigator {
    protected SeekableXPathNavigator() { }
    public abstract long CurrentPosition { get; set; }
    public abstract System.Xml.XmlNodeOrder ComparePosition(long first, long second);
    public abstract string GetLocalName(long node_position);
    public abstract string GetName(long node_position);
    public abstract string GetNamespace(long node_position);
    public abstract System.Xml.XPath.XPathNodeType GetNodeType(long node_position);
    public abstract string GetValue(long node_position);
  }
  public sealed partial class ServiceThrottle {
    internal ServiceThrottle() { }
    public int MaxConcurrentCalls { get { return default(int); } set { } }
    public int MaxConcurrentInstances { get { return default(int); } set { } }
    public int MaxConcurrentSessions { get { return default(int); } set { } }
  }
  public partial class XPathMessageContext : System.Xml.Xsl.XsltContext {
    public XPathMessageContext() { }
    public XPathMessageContext(System.Xml.NameTable nameTable) { }
    public override bool Whitespace { get { return default(bool); } }
    public override int CompareDocument(string uri1, string uri2) { return default(int); }
    public override bool PreserveWhitespace(System.Xml.XPath.XPathNavigator node) { return default(bool); }
    public override System.Xml.Xsl.IXsltContextFunction ResolveFunction(string prefix, string name, System.Xml.XPath.XPathResultType[] argTypes) { return default(System.Xml.Xsl.IXsltContextFunction); }
    public override System.Xml.Xsl.IXsltContextVariable ResolveVariable(string prefix, string name) { return default(System.Xml.Xsl.IXsltContextVariable); }
  }
  [System.MonoTODOAttribute]
  [System.Xml.Serialization.XmlRootAttribute("XPathMessageFilter", Namespace="http://schemas.microsoft.com/serviceModel/2004/05/xpathfilter")]
  [System.Xml.Serialization.XmlSchemaProviderAttribute("StaticGetSchema")]
  public partial class XPathMessageFilter : System.ServiceModel.Dispatcher.MessageFilter, System.Xml.Serialization.IXmlSerializable {
    public XPathMessageFilter() { }
    public XPathMessageFilter(string xpath) { }
    public XPathMessageFilter(string xpath, System.Xml.XmlNamespaceManager namespaces) { }
    public XPathMessageFilter(string xpath, System.Xml.Xsl.XsltContext namespaces) { }
    [System.MonoTODOAttribute]
    public XPathMessageFilter(System.Xml.XmlReader reader) { }
    [System.MonoTODOAttribute]
    public XPathMessageFilter(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager namespaces) { }
    [System.MonoTODOAttribute]
    public XPathMessageFilter(System.Xml.XmlReader reader, System.Xml.Xsl.XsltContext namespaces) { }
    public System.Xml.XmlNamespaceManager Namespaces { get { return default(System.Xml.XmlNamespaceManager); } }
    public int NodeQuota { get { return default(int); } set { } }
    public string XPath { get { return default(string); } }
    protected internal override System.ServiceModel.Dispatcher.IMessageFilterTable<FilterData> CreateFilterTable<FilterData>() { return default(System.ServiceModel.Dispatcher.IMessageFilterTable<FilterData>); }
    public override bool Match(System.ServiceModel.Channels.Message message) { return default(bool); }
    public override bool Match(System.ServiceModel.Channels.MessageBuffer messageBuffer) { return default(bool); }
    public bool Match(System.ServiceModel.Dispatcher.SeekableXPathNavigator navigator) { return default(bool); }
    public bool Match(System.Xml.XPath.XPathNavigator navigator) { return default(bool); }
    protected virtual System.Xml.Schema.XmlSchema OnGetSchema() { return default(System.Xml.Schema.XmlSchema); }
    protected virtual void OnReadXml(System.Xml.XmlReader reader) { }
    protected virtual void OnWriteXml(System.Xml.XmlWriter writer) { }
    protected void ReadXPath(System.Xml.XmlReader reader, System.Xml.XmlNamespaceManager namespaces) { }
    public static System.Xml.Schema.XmlSchemaType StaticGetSchema(System.Xml.Schema.XmlSchemaSet schemas) { return default(System.Xml.Schema.XmlSchemaType); }
    System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { return default(System.Xml.Schema.XmlSchema); }
    void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
    void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
    public void TrimToSize() { }
    protected void WriteXPath(System.Xml.XmlWriter writer, System.Xml.IXmlNamespaceResolver resolver) { }
    public void WriteXPathTo(System.Xml.XmlWriter writer, string prefix, string localName, string ns, bool writeNamespaces) { }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class XPathMessageFilterTable<TFilterData> : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>>, System.Collections.Generic.IDictionary<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>>, System.Collections.IEnumerable, System.ServiceModel.Dispatcher.IMessageFilterTable<TFilterData> {
    [System.MonoTODOAttribute]
    public XPathMessageFilterTable() { }
    public XPathMessageFilterTable(int quota) { }
    public int Count { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public TFilterData this[System.ServiceModel.Dispatcher.MessageFilter key] { get { return default(TFilterData); } set { } }
    public System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter> Keys { get { return default(System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter>); } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public int NodeQuota { get { return default(int); } set { } }
    public System.Collections.Generic.ICollection<TFilterData> Values { get { return default(System.Collections.Generic.ICollection<TFilterData>); } }
    public void Add(System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData> item) { }
    public void Add(System.ServiceModel.Dispatcher.MessageFilter filter, TFilterData data) { }
    [System.MonoTODOAttribute]
    public void Add(System.ServiceModel.Dispatcher.XPathMessageFilter filter, TFilterData data) { }
    public void Clear() { }
    public bool Contains(System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData> item) { return default(bool); }
    public bool ContainsKey(System.ServiceModel.Dispatcher.MessageFilter key) { return default(bool); }
    public void CopyTo(System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>[] array, int index) { }
    public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>> GetEnumerator() { return default(System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData>>); }
    public bool GetMatchingFilter(System.ServiceModel.Channels.Message message, out System.ServiceModel.Dispatcher.MessageFilter result) { result = default(System.ServiceModel.Dispatcher.MessageFilter); return default(bool); }
    public bool GetMatchingFilter(System.ServiceModel.Channels.MessageBuffer buffer, out System.ServiceModel.Dispatcher.MessageFilter result) { result = default(System.ServiceModel.Dispatcher.MessageFilter); return default(bool); }
    public bool GetMatchingFilter(System.ServiceModel.Dispatcher.SeekableXPathNavigator navigator, out System.ServiceModel.Dispatcher.MessageFilter filter) { filter = default(System.ServiceModel.Dispatcher.MessageFilter); return default(bool); }
    public bool GetMatchingFilter(System.Xml.XPath.XPathNavigator navigator, out System.ServiceModel.Dispatcher.MessageFilter filter) { filter = default(System.ServiceModel.Dispatcher.MessageFilter); return default(bool); }
    public bool GetMatchingFilters(System.ServiceModel.Channels.Message message, System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter> results) { return default(bool); }
    public bool GetMatchingFilters(System.ServiceModel.Channels.MessageBuffer buffer, System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter> results) { return default(bool); }
    public bool GetMatchingFilters(System.ServiceModel.Dispatcher.SeekableXPathNavigator navigator, System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter> results) { return default(bool); }
    public bool GetMatchingFilters(System.Xml.XPath.XPathNavigator navigator, System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.MessageFilter> results) { return default(bool); }
    public bool GetMatchingValue(System.ServiceModel.Channels.Message message, out TFilterData data) { data = default(TFilterData); return default(bool); }
    public bool GetMatchingValue(System.ServiceModel.Channels.MessageBuffer buffer, out TFilterData data) { data = default(TFilterData); return default(bool); }
    public bool GetMatchingValue(System.ServiceModel.Dispatcher.SeekableXPathNavigator navigator, out TFilterData data) { data = default(TFilterData); return default(bool); }
    public bool GetMatchingValue(System.Xml.XPath.XPathNavigator navigator, out TFilterData data) { data = default(TFilterData); return default(bool); }
    public bool GetMatchingValues(System.ServiceModel.Channels.Message message, System.Collections.Generic.ICollection<TFilterData> results) { return default(bool); }
    public bool GetMatchingValues(System.ServiceModel.Channels.MessageBuffer buffer, System.Collections.Generic.ICollection<TFilterData> results) { return default(bool); }
    public bool GetMatchingValues(System.ServiceModel.Dispatcher.SeekableXPathNavigator navigator, System.Collections.Generic.ICollection<TFilterData> results) { return default(bool); }
    public bool GetMatchingValues(System.Xml.XPath.XPathNavigator navigator, System.Collections.Generic.ICollection<TFilterData> results) { return default(bool); }
    public bool Remove(System.Collections.Generic.KeyValuePair<System.ServiceModel.Dispatcher.MessageFilter, TFilterData> item) { return default(bool); }
    public bool Remove(System.ServiceModel.Dispatcher.MessageFilter filter) { return default(bool); }
    public bool Remove(System.ServiceModel.Dispatcher.XPathMessageFilter filter) { return default(bool); }
    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void TrimToSize() { }
    public bool TryGetValue(System.ServiceModel.Dispatcher.MessageFilter filter, out TFilterData data) { data = default(TFilterData); return default(bool); }
  }
  public partial class XPathNavigatorException : System.Xml.XPath.XPathException {
    public XPathNavigatorException() { }
    protected XPathNavigatorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public XPathNavigatorException(string msg) { }
    public XPathNavigatorException(string msg, System.Exception inner) { }
  }
}
namespace System.ServiceModel.MsmqIntegration {
  public partial class MsmqIntegrationBinding : System.ServiceModel.MsmqBindingBase {
    public MsmqIntegrationBinding() { }
    public MsmqIntegrationBinding(System.ServiceModel.MsmqIntegration.MsmqIntegrationSecurityMode securityMode) { }
    [System.MonoTODOAttribute]
    public MsmqIntegrationBinding(string configurationName) { }
    public System.ServiceModel.MsmqIntegration.MsmqIntegrationSecurity Security { get { return default(System.ServiceModel.MsmqIntegration.MsmqIntegrationSecurity); } }
    public System.ServiceModel.MsmqIntegration.MsmqMessageSerializationFormat SerializationFormat { get { return default(System.ServiceModel.MsmqIntegration.MsmqMessageSerializationFormat); } set { } }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { return default(System.ServiceModel.Channels.BindingElementCollection); }
  }
  public sealed partial class MsmqIntegrationBindingElement : System.ServiceModel.Channels.MsmqBindingElementBase {
    public MsmqIntegrationBindingElement() { }
    public override string Scheme { get { return default(string); } }
    public System.ServiceModel.MsmqIntegration.MsmqMessageSerializationFormat SerializationFormat { get { return default(System.ServiceModel.MsmqIntegration.MsmqMessageSerializationFormat); } set { } }
    public System.Type[] TargetSerializationTypes { get { return default(System.Type[]); } set { } }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelFactory<TChannel>); }
    [System.MonoTODOAttribute]
    public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(System.ServiceModel.Channels.IChannelListener<TChannel>); }
    public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { return default(bool); }
    public override System.ServiceModel.Channels.BindingElement Clone() { return default(System.ServiceModel.Channels.BindingElement); }
    public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { return default(T); }
  }
  public sealed partial class MsmqIntegrationMessageProperty {
    public const string Name = "MsmqIntegrationMessageProperty";
    public MsmqIntegrationMessageProperty() { }
    public System.Nullable<System.Messaging.AcknowledgeTypes> AcknowledgeType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Messaging.AcknowledgeTypes>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Messaging.Acknowledgment> Acknowledgment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Messaging.Acknowledgment>); } }
    public System.Uri AdministrationQueue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> AppSpecific { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.DateTime> ArrivedTime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.DateTime>); } }
    public System.Nullable<System.Boolean> Authenticated { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Boolean>); } }
    public object Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Int32> BodyType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Int32>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string CorrelationId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Uri DestinationQueue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } }
    public System.Byte[] Extension { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public string Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Label { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Nullable<System.Messaging.MessageType> MessageType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Messaging.MessageType>); } }
    public System.Nullable<System.Messaging.MessagePriority> Priority { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.Messaging.MessagePriority>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Uri ResponseQueue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Uri); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Byte[] SenderId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Byte[]); } }
    public System.Nullable<System.DateTime> SentTime { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.DateTime>); } }
    public System.Nullable<System.TimeSpan> TimeToReachQueue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Nullable<System.TimeSpan>); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public static System.ServiceModel.MsmqIntegration.MsmqIntegrationMessageProperty Get(System.ServiceModel.Channels.Message message) { return default(System.ServiceModel.MsmqIntegration.MsmqIntegrationMessageProperty); }
  }
  public sealed partial class MsmqIntegrationSecurity {
    public MsmqIntegrationSecurity() { }
    public System.ServiceModel.MsmqIntegration.MsmqIntegrationSecurityMode Mode { get { return default(System.ServiceModel.MsmqIntegration.MsmqIntegrationSecurityMode); } set { } }
    public System.ServiceModel.MsmqTransportSecurity Transport { get { return default(System.ServiceModel.MsmqTransportSecurity); } }
  }
  public enum MsmqIntegrationSecurityMode {
    None = 0,
    Transport = 1,
  }
  [System.ServiceModel.MessageContractAttribute]
  public sealed partial class MsmqMessage<T> {
    public MsmqMessage(T body) { }
    public System.Nullable<System.Messaging.AcknowledgeTypes> AcknowledgeType { get { return default(System.Nullable<System.Messaging.AcknowledgeTypes>); } set { } }
    public System.Nullable<System.Messaging.Acknowledgment> Acknowledgment { get { return default(System.Nullable<System.Messaging.Acknowledgment>); } }
    public System.Uri AdministrationQueue { get { return default(System.Uri); } set { } }
    public System.Nullable<System.Int32> AppSpecific { get { return default(System.Nullable<System.Int32>); } set { } }
    public System.Nullable<System.DateTime> ArrivedTime { get { return default(System.Nullable<System.DateTime>); } }
    public System.Nullable<System.Boolean> Authenticated { get { return default(System.Nullable<System.Boolean>); } }
    public T Body { get { return default(T); } set { } }
    public System.Nullable<System.Int32> BodyType { get { return default(System.Nullable<System.Int32>); } set { } }
    public string CorrelationId { get { return default(string); } set { } }
    public System.Uri DestinationQueue { get { return default(System.Uri); } }
    public System.Byte[] Extension { get { return default(System.Byte[]); } set { } }
    public string Id { get { return default(string); } }
    public string Label { get { return default(string); } set { } }
    public System.Nullable<System.Messaging.MessageType> MessageType { get { return default(System.Nullable<System.Messaging.MessageType>); } }
    public System.Nullable<System.Messaging.MessagePriority> Priority { get { return default(System.Nullable<System.Messaging.MessagePriority>); } set { } }
    public System.Uri ResponseQueue { get { return default(System.Uri); } set { } }
    public System.Byte[] SenderId { get { return default(System.Byte[]); } }
    public System.Nullable<System.DateTime> SentTime { get { return default(System.Nullable<System.DateTime>); } }
    public System.Nullable<System.TimeSpan> TimeToReachQueue { get { return default(System.Nullable<System.TimeSpan>); } set { } }
  }
  public enum MsmqMessageSerializationFormat {
    ActiveX = 2,
    Binary = 1,
    ByteArray = 3,
    Stream = 4,
    Xml = 0,
  }
}
namespace System.ServiceModel.PeerResolvers {
  [System.MonoTODOAttribute("Implement cleanup and refresh")]
  [System.ServiceModel.ServiceBehaviorAttribute(ConcurrencyMode=(System.ServiceModel.ConcurrencyMode)(2), InstanceContextMode=(System.ServiceModel.InstanceContextMode)(2), UseSynchronizationContext=false)]
  public partial class CustomPeerResolverService : System.ServiceModel.PeerResolvers.IPeerResolverContract {
    public CustomPeerResolverService() { }
    public System.TimeSpan CleanupInterval { get { return default(System.TimeSpan); } set { } }
    public bool ControlShape { get { return default(bool); } set { } }
    public System.TimeSpan RefreshInterval { get { return default(System.TimeSpan); } set { } }
    [System.MonoTODOAttribute("Do we have to unregister nodes here?")]
    public virtual void Close() { }
    public virtual System.ServiceModel.PeerResolvers.ServiceSettingsResponseInfo GetServiceSettings() { return default(System.ServiceModel.PeerResolvers.ServiceSettingsResponseInfo); }
    public virtual void Open() { }
    public virtual System.ServiceModel.PeerResolvers.RefreshResponseInfo Refresh(System.ServiceModel.PeerResolvers.RefreshInfo refreshInfo) { return default(System.ServiceModel.PeerResolvers.RefreshResponseInfo); }
    public virtual System.ServiceModel.PeerResolvers.RegisterResponseInfo Register(System.Guid clientId, string meshId, System.ServiceModel.PeerNodeAddress address) { return default(System.ServiceModel.PeerResolvers.RegisterResponseInfo); }
    public virtual System.ServiceModel.PeerResolvers.RegisterResponseInfo Register(System.ServiceModel.PeerResolvers.RegisterInfo registerInfo) { return default(System.ServiceModel.PeerResolvers.RegisterResponseInfo); }
    public virtual System.ServiceModel.PeerResolvers.ResolveResponseInfo Resolve(System.ServiceModel.PeerResolvers.ResolveInfo resolveInfo) { return default(System.ServiceModel.PeerResolvers.ResolveResponseInfo); }
    public virtual void Unregister(System.ServiceModel.PeerResolvers.UnregisterInfo unregisterInfo) { }
    public virtual System.ServiceModel.PeerResolvers.RegisterResponseInfo Update(System.ServiceModel.PeerResolvers.UpdateInfo updateInfo) { return default(System.ServiceModel.PeerResolvers.RegisterResponseInfo); }
  }
  [System.ServiceModel.ServiceContractAttribute(Name="IPeerResolverContract", Namespace="http://schemas.microsoft.com/net/2006/05/peer/resolver", SessionMode=(System.ServiceModel.SessionMode)(0))]
  public partial interface IPeerResolverContract {
    [System.ServiceModel.OperationContractAttribute(IsOneWay=false, Name="GetServiceInfo", Action="http://schemas.microsoft.com/net/2006/05/peer/resolver/GetServiceSettings", ReplyAction="http://schemas.microsoft.com/net/2006/05/peer/resolver/GetServiceSettingsResponse")]
    System.ServiceModel.PeerResolvers.ServiceSettingsResponseInfo GetServiceSettings();
    [System.ServiceModel.OperationContractAttribute(IsOneWay=false, Name="Refresh", Action="http://schemas.microsoft.com/net/2006/05/peer/resolver/Refresh", ReplyAction="http://schemas.microsoft.com/net/2006/05/peer/resolver/RefreshResponse")]
    System.ServiceModel.PeerResolvers.RefreshResponseInfo Refresh(System.ServiceModel.PeerResolvers.RefreshInfo refreshInfo);
    [System.ServiceModel.OperationContractAttribute(IsOneWay=false, Name="Register", Action="http://schemas.microsoft.com/net/2006/05/peer/resolver/Register", ReplyAction="http://schemas.microsoft.com/net/2006/05/peer/resolver/RegisterResponse")]
    System.ServiceModel.PeerResolvers.RegisterResponseInfo Register(System.ServiceModel.PeerResolvers.RegisterInfo registerInfo);
    [System.ServiceModel.OperationContractAttribute(IsOneWay=false, Name="Resolve", Action="http://schemas.microsoft.com/net/2006/05/peer/resolver/Resolve", ReplyAction="http://schemas.microsoft.com/net/2006/05/peer/resolver/ResolveResponse")]
    System.ServiceModel.PeerResolvers.ResolveResponseInfo Resolve(System.ServiceModel.PeerResolvers.ResolveInfo resolveInfo);
    [System.ServiceModel.OperationContractAttribute(IsOneWay=false, Name="Unregister", Action="http://schemas.microsoft.com/net/2006/05/peer/resolver/Unregister")]
    void Unregister(System.ServiceModel.PeerResolvers.UnregisterInfo unregisterInfo);
    [System.ServiceModel.OperationContractAttribute(IsOneWay=false, Name="Update", Action="http://schemas.microsoft.com/net/2006/05/peer/resolver/Update", ReplyAction="http://schemas.microsoft.com/net/2006/05/peer/resolver/UpdateResponse")]
    System.ServiceModel.PeerResolvers.RegisterResponseInfo Update(System.ServiceModel.PeerResolvers.UpdateInfo updateInfo);
  }
  public partial class PeerCustomResolverSettings {
    public PeerCustomResolverSettings() { }
    public System.ServiceModel.EndpointAddress Address { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.EndpointAddress); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.Channels.Binding Binding { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Channels.Binding); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public bool IsBindingSpecified { get { return default(bool); } }
    public System.ServiceModel.PeerResolver Resolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.PeerResolver); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public enum PeerReferralPolicy {
    DoNotShare = 2,
    Service = 0,
    Share = 1,
  }
  public enum PeerResolverMode {
    Auto = 0,
    Custom = 2,
    Pnrp = 1,
  }
  public partial class PeerResolverSettings {
    public PeerResolverSettings() { }
    public System.ServiceModel.PeerResolvers.PeerCustomResolverSettings Custom { get { return default(System.ServiceModel.PeerResolvers.PeerCustomResolverSettings); } }
    public System.ServiceModel.PeerResolvers.PeerResolverMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.PeerResolvers.PeerResolverMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.ServiceModel.PeerResolvers.PeerReferralPolicy ReferralPolicy { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.PeerResolvers.PeerReferralPolicy); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
  public partial class RefreshInfo {
    public RefreshInfo() { }
    public RefreshInfo(string meshId, System.Guid regId) { }
    public string MeshId { get { return default(string); } }
    public System.Guid RegistrationId { get { return default(System.Guid); } }
    public bool HasBody() { return default(bool); }
  }
  [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
  public partial class RefreshResponseInfo {
    public RefreshResponseInfo() { }
    public RefreshResponseInfo(System.TimeSpan registrationLifetime, System.ServiceModel.PeerResolvers.RefreshResult result) { }
    public System.TimeSpan RegistrationLifetime { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.PeerResolvers.RefreshResult Result { get { return default(System.ServiceModel.PeerResolvers.RefreshResult); } set { } }
    public bool HasBody() { return default(bool); }
  }
  public enum RefreshResult {
    RegistrationNotFound = 1,
    Success = 0,
  }
  [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
  public partial class RegisterInfo {
    public RegisterInfo() { }
    public RegisterInfo(System.Guid client, string meshId, System.ServiceModel.PeerNodeAddress address) { }
    public System.Guid ClientId { get { return default(System.Guid); } }
    public string MeshId { get { return default(string); } }
    public System.ServiceModel.PeerNodeAddress NodeAddress { get { return default(System.ServiceModel.PeerNodeAddress); } }
    public bool HasBody() { return default(bool); }
  }
  [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
  public partial class RegisterResponseInfo {
    public RegisterResponseInfo() { }
    public RegisterResponseInfo(System.Guid registrationId, System.TimeSpan registrationLifetime) { }
    public System.Guid RegistrationId { get { return default(System.Guid); } set { } }
    public System.TimeSpan RegistrationLifetime { get { return default(System.TimeSpan); } set { } }
    public bool HasBody() { return default(bool); }
  }
  [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
  public partial class ResolveInfo {
    public ResolveInfo() { }
    public ResolveInfo(System.Guid clientId, string meshId, int maxAddresses) { }
    public System.Guid ClientId { get { return default(System.Guid); } }
    public int MaxAddresses { get { return default(int); } }
    public string MeshId { get { return default(string); } }
    public bool HasBody() { return default(bool); }
  }
  [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
  public partial class ResolveResponseInfo {
    public ResolveResponseInfo() { }
    public ResolveResponseInfo(System.ServiceModel.PeerNodeAddress[] addresses) { }
    public System.Collections.Generic.IList<System.ServiceModel.PeerNodeAddress> Addresses { get { return default(System.Collections.Generic.IList<System.ServiceModel.PeerNodeAddress>); } set { } }
    public bool HasBody() { return default(bool); }
  }
  [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
  public partial class ServiceSettingsResponseInfo {
    public ServiceSettingsResponseInfo() { }
    public ServiceSettingsResponseInfo(bool control) { }
    public bool ControlMeshShape { get { return default(bool); } set { } }
    public bool HasBody() { return default(bool); }
  }
  [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
  public partial class UnregisterInfo {
    public UnregisterInfo() { }
    public UnregisterInfo(string meshId, System.Guid registration_id) { }
    public string MeshId { get { return default(string); } }
    public System.Guid RegistrationId { get { return default(System.Guid); } }
    public bool HasBody() { return default(bool); }
  }
  [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
  public partial class UpdateInfo {
    public UpdateInfo() { }
    public UpdateInfo(System.Guid registrationId, System.Guid client, string meshId, System.ServiceModel.PeerNodeAddress address) { }
    public System.Guid ClientId { get { return default(System.Guid); } }
    public string MeshId { get { return default(string); } }
    public System.ServiceModel.PeerNodeAddress NodeAddress { get { return default(System.ServiceModel.PeerNodeAddress); } }
    public System.Guid RegistrationId { get { return default(System.Guid); } }
    public bool HasBody() { return default(bool); }
  }
}
namespace System.ServiceModel.Security {
  public abstract partial class BasicSecurityProfileVersion {
    internal BasicSecurityProfileVersion() { }
    public static System.ServiceModel.Security.BasicSecurityProfileVersion BasicSecurityProfile10 { get { return default(System.ServiceModel.Security.BasicSecurityProfileVersion); } }
  }
  public partial class BinarySecretKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause {
    public BinarySecretKeyIdentifierClause(System.Byte[] key) : base (default(string), default(System.Byte[]), default(bool)) { }
    [System.MonoTODOAttribute("ClauseType")]
    public BinarySecretKeyIdentifierClause(System.Byte[] key, bool cloneBuffer) : base (default(string), default(System.Byte[]), default(bool)) { }
    [System.MonoTODOAttribute("ClauseType")]
    public BinarySecretKeyIdentifierClause(System.Byte[] key, bool cloneBuffer, System.Byte[] derivationNonce, int derivationLength) : base (default(string), default(System.Byte[]), default(bool)) { }
    public override bool CanCreateKey { get { return default(bool); } }
    public override System.IdentityModel.Tokens.SecurityKey CreateKey() { return default(System.IdentityModel.Tokens.SecurityKey); }
    public System.Byte[] GetKeyBytes() { return default(System.Byte[]); }
    public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { return default(bool); }
  }
  public partial class ChannelProtectionRequirements {
    public ChannelProtectionRequirements() { }
    public ChannelProtectionRequirements(System.ServiceModel.Security.ChannelProtectionRequirements other) { }
    public System.ServiceModel.Security.ScopedMessagePartSpecification IncomingEncryptionParts { get { return default(System.ServiceModel.Security.ScopedMessagePartSpecification); } }
    public System.ServiceModel.Security.ScopedMessagePartSpecification IncomingSignatureParts { get { return default(System.ServiceModel.Security.ScopedMessagePartSpecification); } }
    public bool IsReadOnly { get { return default(bool); } }
    public System.ServiceModel.Security.ScopedMessagePartSpecification OutgoingEncryptionParts { get { return default(System.ServiceModel.Security.ScopedMessagePartSpecification); } }
    public System.ServiceModel.Security.ScopedMessagePartSpecification OutgoingSignatureParts { get { return default(System.ServiceModel.Security.ScopedMessagePartSpecification); } }
    public void Add(System.ServiceModel.Security.ChannelProtectionRequirements protectionRequirements) { }
    public void Add(System.ServiceModel.Security.ChannelProtectionRequirements protectionRequirements, bool channelScopeOnly) { }
    public System.ServiceModel.Security.ChannelProtectionRequirements CreateInverse() { return default(System.ServiceModel.Security.ChannelProtectionRequirements); }
    public void MakeReadOnly() { }
  }
  public partial class DataProtectionSecurityStateEncoder : System.ServiceModel.Security.SecurityStateEncoder {
    public DataProtectionSecurityStateEncoder() { }
    public DataProtectionSecurityStateEncoder(bool useCurrentUserProtectionScope) { }
    public DataProtectionSecurityStateEncoder(bool useCurrentUserProtectionScope, System.Byte[] entropy) { }
    public bool UseCurrentUserProtectionScope { get { return default(bool); } }
    protected internal override System.Byte[] DecodeSecurityState(System.Byte[] data) { return default(System.Byte[]); }
    protected internal override System.Byte[] EncodeSecurityState(System.Byte[] data) { return default(System.Byte[]); }
    public System.Byte[] GetEntropy() { return default(System.Byte[]); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public partial class ExpiredSecurityTokenException : System.ServiceModel.Security.MessageSecurityException {
    public ExpiredSecurityTokenException() { }
    protected ExpiredSecurityTokenException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public ExpiredSecurityTokenException(string message) { }
    public ExpiredSecurityTokenException(string message, System.Exception innerException) { }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) { }
  }
  public sealed partial class HttpDigestClientCredential {
    internal HttpDigestClientCredential() { }
    public System.Security.Principal.TokenImpersonationLevel AllowedImpersonationLevel { get { return default(System.Security.Principal.TokenImpersonationLevel); } set { } }
    public System.Net.NetworkCredential ClientCredential { get { return default(System.Net.NetworkCredential); } set { } }
  }
  [System.MonoTODOAttribute]
  public abstract partial class IdentityVerifier {
    protected IdentityVerifier() { }
    public abstract bool CheckAccess(System.ServiceModel.EndpointIdentity identity, System.IdentityModel.Policy.AuthorizationContext authContext);
    [System.MonoTODOAttribute]
    public static System.ServiceModel.Security.IdentityVerifier CreateDefault() { return default(System.ServiceModel.Security.IdentityVerifier); }
    public abstract bool TryGetIdentity(System.ServiceModel.EndpointAddress reference, out System.ServiceModel.EndpointIdentity identity);
  }
  public partial interface IEndpointIdentityProvider {
    System.ServiceModel.EndpointIdentity GetIdentityOfSelf(System.IdentityModel.Selectors.SecurityTokenRequirement tokenRequirement);
  }
  [System.MonoTODOAttribute]
  public partial class InfocardInteractiveChannelInitializer : System.ServiceModel.Dispatcher.IInteractiveChannelInitializer {
    [System.MonoTODOAttribute]
    public InfocardInteractiveChannelInitializer(System.ServiceModel.Description.ClientCredentials credentials, System.ServiceModel.Channels.Binding binding) { }
    public System.ServiceModel.Channels.Binding Binding { get { return default(System.ServiceModel.Channels.Binding); } }
    [System.MonoTODOAttribute]
    public System.IAsyncResult BeginDisplayInitializationUI(System.ServiceModel.IClientChannel channel, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    public void EndDisplayInitializationUI(System.IAsyncResult result) { }
  }
  public partial interface ISecureConversationSession : System.ServiceModel.Channels.ISession, System.ServiceModel.Security.ISecuritySession {
    bool TryReadSessionTokenIdentifier(System.Xml.XmlReader reader);
    void WriteSessionTokenIdentifier(System.Xml.XmlDictionaryWriter writer);
  }
  public partial interface ISecuritySession : System.ServiceModel.Channels.ISession {
    System.ServiceModel.EndpointIdentity RemoteIdentity { get; }
  }
  [System.MonoTODOAttribute]
  public sealed partial class IssuedTokenClientCredential {
    internal IssuedTokenClientCredential() { }
    public bool CacheIssuedTokens { get { return default(bool); } set { } }
    public System.ServiceModel.Security.SecurityKeyEntropyMode DefaultKeyEntropyMode { get { return default(System.ServiceModel.Security.SecurityKeyEntropyMode); } set { } }
    public int IssuedTokenRenewalThresholdPercentage { get { return default(int); } set { } }
    public System.Collections.Generic.Dictionary<System.Uri, System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IEndpointBehavior>> IssuerChannelBehaviors { get { return default(System.Collections.Generic.Dictionary<System.Uri, System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IEndpointBehavior>>); } }
    public System.ServiceModel.EndpointAddress LocalIssuerAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.Binding LocalIssuerBinding { get { return default(System.ServiceModel.Channels.Binding); } set { } }
    public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IEndpointBehavior> LocalIssuerChannelBehaviors { get { return default(System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IEndpointBehavior>); } }
    public System.TimeSpan MaxIssuedTokenCachingTime { get { return default(System.TimeSpan); } set { } }
  }
  [System.MonoTODOAttribute]
  public partial class IssuedTokenServiceCredential {
    internal IssuedTokenServiceCredential() { }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.IList<System.String> AllowedAudienceUris { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IList<System.String>); } }
    [System.MonoTODOAttribute]
    public bool AllowUntrustedRsaIssuers { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Selectors.AudienceUriMode AudienceUriMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.IdentityModel.Selectors.AudienceUriMode); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { return default(System.ServiceModel.Security.X509CertificateValidationMode); } set { } }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Selectors.X509CertificateValidator CustomCertificateValidator { get { return default(System.IdentityModel.Selectors.X509CertificateValidator); } set { } }
    [System.MonoTODOAttribute]
    public System.Collections.Generic.IList<System.Security.Cryptography.X509Certificates.X509Certificate2> KnownCertificates { get { return default(System.Collections.Generic.IList<System.Security.Cryptography.X509Certificates.X509Certificate2>); } }
    [System.MonoTODOAttribute]
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } set { } }
    [System.MonoTODOAttribute]
    public System.IdentityModel.Tokens.SamlSerializer SamlSerializer { get { return default(System.IdentityModel.Tokens.SamlSerializer); } set { } }
    [System.MonoTODOAttribute]
    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
  }
  public partial class KeyNameIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause {
    public KeyNameIdentifierClause(string keyName) : base (default(string)) { }
    public string KeyName { get { return default(string); } }
    public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { return default(bool); }
    public bool Matches(string keyName) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public partial class MessagePartSpecification {
    public MessagePartSpecification() { }
    public MessagePartSpecification(bool isBodyIncluded) { }
    public MessagePartSpecification(bool isBodyIncluded, params System.Xml.XmlQualifiedName[] headerTypes) { }
    public MessagePartSpecification(params System.Xml.XmlQualifiedName[] headerTypes) { }
    public System.Collections.Generic.ICollection<System.Xml.XmlQualifiedName> HeaderTypes { get { return default(System.Collections.Generic.ICollection<System.Xml.XmlQualifiedName>); } }
    public bool IsBodyIncluded { get { return default(bool); } set { } }
    public bool IsReadOnly { get { return default(bool); } }
    public static System.ServiceModel.Security.MessagePartSpecification NoParts { get { return default(System.ServiceModel.Security.MessagePartSpecification); } }
    public void Clear() { }
    public void MakeReadOnly() { }
    public void Union(System.ServiceModel.Security.MessagePartSpecification other) { }
  }
  public enum MessageProtectionOrder {
    EncryptBeforeSign = 2,
    SignBeforeEncrypt = 0,
    SignBeforeEncryptAndEncryptSignature = 1,
  }
  public partial class MessageSecurityException : System.ServiceModel.CommunicationException {
    public MessageSecurityException() { }
    protected MessageSecurityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MessageSecurityException(string message) { }
    public MessageSecurityException(string message, System.Exception innerException) { }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) { }
  }
  public partial class PeerCredential {
    internal PeerCredential() { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } set { } }
    public string MeshPassword { get { return default(string); } set { } }
    public System.ServiceModel.Security.X509PeerCertificateAuthentication MessageSenderAuthentication { get { return default(System.ServiceModel.Security.X509PeerCertificateAuthentication); } set { } }
    public System.ServiceModel.Security.X509PeerCertificateAuthentication PeerAuthentication { get { return default(System.ServiceModel.Security.X509PeerCertificateAuthentication); } set { } }
    [System.MonoTODOAttribute]
    public void SetCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
    [System.MonoTODOAttribute]
    public void SetCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName) { }
  }
  public partial class ScopedMessagePartSpecification {
    public ScopedMessagePartSpecification() { }
    public ScopedMessagePartSpecification(System.ServiceModel.Security.ScopedMessagePartSpecification other) { }
    public System.Collections.Generic.ICollection<System.String> Actions { get { return default(System.Collections.Generic.ICollection<System.String>); } }
    public System.ServiceModel.Security.MessagePartSpecification ChannelParts { get { return default(System.ServiceModel.Security.MessagePartSpecification); } }
    public bool IsReadOnly { get { return default(bool); } }
    public void AddParts(System.ServiceModel.Security.MessagePartSpecification parts) { }
    public void AddParts(System.ServiceModel.Security.MessagePartSpecification parts, string action) { }
    public void MakeReadOnly() { }
    public bool TryGetParts(string action, bool excludeChannelScope, out System.ServiceModel.Security.MessagePartSpecification parts) { parts = default(System.ServiceModel.Security.MessagePartSpecification); return default(bool); }
    public bool TryGetParts(string action, out System.ServiceModel.Security.MessagePartSpecification parts) { parts = default(System.ServiceModel.Security.MessagePartSpecification); return default(bool); }
  }
  public sealed partial class SecureConversationServiceCredential {
    internal SecureConversationServiceCredential() { }
    public System.Collections.ObjectModel.Collection<System.Type> SecurityContextClaimTypes { get { return default(System.Collections.ObjectModel.Collection<System.Type>); } }
    public System.ServiceModel.Security.SecurityStateEncoder SecurityStateEncoder { get { return default(System.ServiceModel.Security.SecurityStateEncoder); } set { } }
  }
  public abstract partial class SecureConversationVersion {
    protected SecureConversationVersion() { }
    public static System.ServiceModel.Security.SecureConversationVersion Default { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.SecureConversationVersion); } }
    public System.Xml.XmlDictionaryString Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.XmlDictionaryString); } }
    public System.Xml.XmlDictionaryString Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.XmlDictionaryString); } }
    public static System.ServiceModel.Security.SecureConversationVersion WSSecureConversation13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.SecureConversationVersion); } }
    public static System.ServiceModel.Security.SecureConversationVersion WSSecureConversationFeb2005 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.SecureConversationVersion); } }
  }
  public partial class SecurityAccessDeniedException : System.ServiceModel.CommunicationException {
    public SecurityAccessDeniedException() { }
    protected SecurityAccessDeniedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SecurityAccessDeniedException(string message) { }
    public SecurityAccessDeniedException(string message, System.Exception innerException) { }
  }
  public abstract partial class SecurityAlgorithmSuite {
    protected SecurityAlgorithmSuite() { }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic128 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic128Rsa15 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic128Sha256 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic128Sha256Rsa15 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic192 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic192Rsa15 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic192Sha256 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic192Sha256Rsa15 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic256 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic256Rsa15 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic256Sha256 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Basic256Sha256Rsa15 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite Default { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public abstract string DefaultAsymmetricKeyWrapAlgorithm { get; }
    public abstract string DefaultAsymmetricSignatureAlgorithm { get; }
    public abstract string DefaultCanonicalizationAlgorithm { get; }
    public abstract string DefaultDigestAlgorithm { get; }
    public abstract string DefaultEncryptionAlgorithm { get; }
    public abstract int DefaultEncryptionKeyDerivationLength { get; }
    public abstract int DefaultSignatureKeyDerivationLength { get; }
    public abstract int DefaultSymmetricKeyLength { get; }
    public abstract string DefaultSymmetricKeyWrapAlgorithm { get; }
    public abstract string DefaultSymmetricSignatureAlgorithm { get; }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite TripleDes { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite TripleDesRsa15 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite TripleDesSha256 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public static System.ServiceModel.Security.SecurityAlgorithmSuite TripleDesSha256Rsa15 { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } }
    public abstract bool IsAsymmetricKeyLengthSupported(int length);
    public virtual bool IsAsymmetricKeyWrapAlgorithmSupported(string algorithm) { return default(bool); }
    public virtual bool IsAsymmetricSignatureAlgorithmSupported(string algorithm) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool IsCanonicalizationAlgorithmSupported(string algorithm) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool IsDigestAlgorithmSupported(string algorithm) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool IsEncryptionAlgorithmSupported(string algorithm) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool IsEncryptionKeyDerivationAlgorithmSupported(string algorithm) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool IsSignatureKeyDerivationAlgorithmSupported(string algorithm) { return default(bool); }
    public abstract bool IsSymmetricKeyLengthSupported(int length);
    [System.MonoTODOAttribute]
    public virtual bool IsSymmetricKeyWrapAlgorithmSupported(string algorithm) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual bool IsSymmetricSignatureAlgorithmSupported(string algorithm) { return default(bool); }
  }
  public partial class SecurityContextKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause {
    public SecurityContextKeyIdentifierClause(System.Xml.UniqueId contextId) : base (default(string)) { }
    public SecurityContextKeyIdentifierClause(System.Xml.UniqueId contextId, System.Xml.UniqueId generation) : base (default(string)) { }
    public SecurityContextKeyIdentifierClause(System.Xml.UniqueId contextId, System.Xml.UniqueId generation, System.Byte[] derivationNonce, int derivationLength) : base (default(string)) { }
    public System.Xml.UniqueId ContextId { get { return default(System.Xml.UniqueId); } }
    public System.Xml.UniqueId Generation { get { return default(System.Xml.UniqueId); } }
    public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { return default(bool); }
    public bool Matches(System.Xml.UniqueId contextId, System.Xml.UniqueId generation) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public abstract partial class SecurityCredentialsManager {
    protected SecurityCredentialsManager() { }
    public abstract System.IdentityModel.Selectors.SecurityTokenManager CreateSecurityTokenManager();
  }
  public enum SecurityKeyEntropyMode {
    ClientEntropy = 0,
    CombinedEntropy = 2,
    ServerEntropy = 1,
  }
  public partial class SecurityMessageProperty : System.IDisposable, System.ServiceModel.Channels.IMessageProperty {
    public SecurityMessageProperty() { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ExternalAuthorizationPolicies { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); } set { } }
    public bool HasIncomingSupportingTokens { get { return default(bool); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.SupportingTokenSpecification> IncomingSupportingTokens { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.SupportingTokenSpecification>); } }
    public System.ServiceModel.Security.SecurityTokenSpecification InitiatorToken { get { return default(System.ServiceModel.Security.SecurityTokenSpecification); } set { } }
    public System.ServiceModel.Security.SecurityTokenSpecification ProtectionToken { get { return default(System.ServiceModel.Security.SecurityTokenSpecification); } set { } }
    public System.ServiceModel.Security.SecurityTokenSpecification RecipientToken { get { return default(System.ServiceModel.Security.SecurityTokenSpecification); } set { } }
    public string SenderIdPrefix { get { return default(string); } set { } }
    public System.ServiceModel.ServiceSecurityContext ServiceSecurityContext { get { return default(System.ServiceModel.ServiceSecurityContext); } set { } }
    public System.ServiceModel.Security.SecurityTokenSpecification TransportToken { get { return default(System.ServiceModel.Security.SecurityTokenSpecification); } set { } }
    public System.ServiceModel.Channels.IMessageProperty CreateCopy() { return default(System.ServiceModel.Channels.IMessageProperty); }
    public void Dispose() { }
    public static System.ServiceModel.Security.SecurityMessageProperty GetOrCreate(System.ServiceModel.Channels.Message message) { return default(System.ServiceModel.Security.SecurityMessageProperty); }
  }
  public partial class SecurityNegotiationException : System.ServiceModel.CommunicationException {
    public SecurityNegotiationException() { }
    protected SecurityNegotiationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public SecurityNegotiationException(string message) { }
    public SecurityNegotiationException(string message, System.Exception innerException) { }
  }
  public abstract partial class SecurityPolicyVersion {
    protected SecurityPolicyVersion() { }
    public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public string Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } }
    public static System.ServiceModel.Security.SecurityPolicyVersion WSSecurityPolicy11 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.SecurityPolicyVersion); } }
    public static System.ServiceModel.Security.SecurityPolicyVersion WSSecurityPolicy12 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.SecurityPolicyVersion); } }
  }
  public abstract partial class SecurityStateEncoder {
    protected SecurityStateEncoder() { }
    protected internal abstract System.Byte[] DecodeSecurityState(System.Byte[] data);
    protected internal abstract System.Byte[] EncodeSecurityState(System.Byte[] data);
  }
  public enum SecurityTokenAttachmentMode {
    Endorsing = 1,
    Signed = 0,
    SignedEncrypted = 3,
    SignedEndorsing = 2,
  }
  public partial class SecurityTokenSpecification {
    public SecurityTokenSpecification(System.IdentityModel.Tokens.SecurityToken token, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> tokenPolicies) { }
    public System.IdentityModel.Tokens.SecurityToken SecurityToken { get { return default(System.IdentityModel.Tokens.SecurityToken); } }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> SecurityTokenPolicies { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); } }
  }
  public abstract partial class SecurityVersion {
    protected SecurityVersion() { }
    public static System.ServiceModel.Security.SecurityVersion WSSecurity10 { get { return default(System.ServiceModel.Security.SecurityVersion); } }
    public static System.ServiceModel.Security.SecurityVersion WSSecurity11 { get { return default(System.ServiceModel.Security.SecurityVersion); } }
  }
  public partial class ServiceCredentialsSecurityTokenManager : System.IdentityModel.Selectors.SecurityTokenManager, System.ServiceModel.Security.IEndpointIdentityProvider {
    public ServiceCredentialsSecurityTokenManager(System.ServiceModel.Description.ServiceCredentials credentials) { }
    public System.ServiceModel.Description.ServiceCredentials ServiceCredentials { get { return default(System.ServiceModel.Description.ServiceCredentials); } }
    [System.MonoTODOAttribute]
    public override System.IdentityModel.Selectors.SecurityTokenAuthenticator CreateSecurityTokenAuthenticator(System.IdentityModel.Selectors.SecurityTokenRequirement requirement, out System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { outOfBandTokenResolver = default(System.IdentityModel.Selectors.SecurityTokenResolver); return default(System.IdentityModel.Selectors.SecurityTokenAuthenticator); }
    [System.MonoTODOAttribute]
    public override System.IdentityModel.Selectors.SecurityTokenProvider CreateSecurityTokenProvider(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { return default(System.IdentityModel.Selectors.SecurityTokenProvider); }
    [System.MonoTODOAttribute("pass correct arguments to WSSecurityTokenSerializer..ctor()")]
    public override System.IdentityModel.Selectors.SecurityTokenSerializer CreateSecurityTokenSerializer(System.IdentityModel.Selectors.SecurityTokenVersion version) { return default(System.IdentityModel.Selectors.SecurityTokenSerializer); }
    [System.MonoTODOAttribute]
    public virtual System.ServiceModel.EndpointIdentity GetIdentityOfSelf(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { return default(System.ServiceModel.EndpointIdentity); }
    protected internal bool IsIssuedSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { return default(bool); }
  }
  public partial class SspiSecurityTokenProvider : System.IdentityModel.Selectors.SecurityTokenProvider {
    [System.MonoTODOAttribute]
    public SspiSecurityTokenProvider(System.Net.NetworkCredential credential, bool extractGroupsForWindowsAccounts, bool allowUnauthenticatedCallers) { }
    public SspiSecurityTokenProvider(System.Net.NetworkCredential credential, bool allowNtlm, System.Security.Principal.TokenImpersonationLevel impersonationLevel) { }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout) { return default(System.IdentityModel.Tokens.SecurityToken); }
  }
  public partial class SupportingTokenSpecification : System.ServiceModel.Security.SecurityTokenSpecification {
    public SupportingTokenSpecification(System.IdentityModel.Tokens.SecurityToken token, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> tokenPolicies, System.ServiceModel.Security.SecurityTokenAttachmentMode attachmentMode) : base (default(System.IdentityModel.Tokens.SecurityToken), default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>)) { }
    public System.ServiceModel.Security.SecurityTokenAttachmentMode SecurityTokenAttachmentMode { get { return default(System.ServiceModel.Security.SecurityTokenAttachmentMode); } }
  }
  public abstract partial class TrustVersion {
    protected TrustVersion() { }
    public static System.ServiceModel.Security.TrustVersion Default { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.TrustVersion); } }
    public System.Xml.XmlDictionaryString Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.XmlDictionaryString); } }
    public System.Xml.XmlDictionaryString Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Xml.XmlDictionaryString); } }
    public static System.ServiceModel.Security.TrustVersion WSTrust13 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.TrustVersion); } }
    public static System.ServiceModel.Security.TrustVersion WSTrustFeb2005 { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.ServiceModel.Security.TrustVersion); } }
  }
  public sealed partial class UserNamePasswordClientCredential {
    internal UserNamePasswordClientCredential() { }
    public string Password { get { return default(string); } set { } }
    public string UserName { get { return default(string); } set { } }
  }
  public sealed partial class UserNamePasswordServiceCredential {
    internal UserNamePasswordServiceCredential() { }
    [System.MonoTODOAttribute]
    public System.TimeSpan CachedLogonTokenLifetime { get { return default(System.TimeSpan); } set { } }
    [System.MonoTODOAttribute]
    public bool CacheLogonTokens { get { return default(bool); } set { } }
    public System.IdentityModel.Selectors.UserNamePasswordValidator CustomUserNamePasswordValidator { get { return default(System.IdentityModel.Selectors.UserNamePasswordValidator); } set { } }
    [System.MonoTODOAttribute]
    public bool IncludeWindowsGroups { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public int MaxCachedLogonTokens { get { return default(int); } set { } }
    public System.Web.Security.MembershipProvider MembershipProvider { get { return default(System.Web.Security.MembershipProvider); } set { } }
    [System.MonoTODOAttribute]
    public System.ServiceModel.Security.UserNamePasswordValidationMode UserNamePasswordValidationMode { get { return default(System.ServiceModel.Security.UserNamePasswordValidationMode); } set { } }
  }
  public enum UserNamePasswordValidationMode {
    Custom = 2,
    MembershipProvider = 1,
    Windows = 0,
  }
  public sealed partial class WindowsClientCredential {
    internal WindowsClientCredential() { }
    public System.Security.Principal.TokenImpersonationLevel AllowedImpersonationLevel { get { return default(System.Security.Principal.TokenImpersonationLevel); } set { } }
    public bool AllowNtlm { get { return default(bool); } set { } }
    [System.MonoTODOAttribute]
    public System.Net.NetworkCredential ClientCredential { get { return default(System.Net.NetworkCredential); } set { } }
  }
  public sealed partial class WindowsServiceCredential {
    internal WindowsServiceCredential() { }
    public bool AllowAnonymousLogons { get { return default(bool); } set { } }
    public bool IncludeWindowsGroups { get { return default(bool); } set { } }
  }
  public partial class WSSecurityTokenSerializer : System.IdentityModel.Selectors.SecurityTokenSerializer {
    public WSSecurityTokenSerializer() { }
    public WSSecurityTokenSerializer(bool emitBspRequiredAttributes) { }
    public WSSecurityTokenSerializer(System.ServiceModel.Security.SecurityVersion securityVersion) { }
    public WSSecurityTokenSerializer(System.ServiceModel.Security.SecurityVersion securityVersion, bool emitBspRequiredAttributes) { }
    public WSSecurityTokenSerializer(System.ServiceModel.Security.SecurityVersion securityVersion, bool emitBspRequiredAttributes, System.IdentityModel.Tokens.SamlSerializer samlSerializer) { }
    public WSSecurityTokenSerializer(System.ServiceModel.Security.SecurityVersion securityVersion, bool emitBspRequiredAttributes, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.ServiceModel.Security.SecurityStateEncoder securityStateEncoder, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
    public WSSecurityTokenSerializer(System.ServiceModel.Security.SecurityVersion securityVersion, bool emitBspRequiredAttributes, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.ServiceModel.Security.SecurityStateEncoder securityStateEncoder, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maximumKeyDerivationOffset, int maximumKeyDerivationLabelLength, int maximumKeyDerivationNonceLength) { }
    public static System.ServiceModel.Security.WSSecurityTokenSerializer DefaultInstance { get { return default(System.ServiceModel.Security.WSSecurityTokenSerializer); } }
    public bool EmitBspRequiredAttributes { get { return default(bool); } }
    [System.MonoTODOAttribute]
    public int MaximumKeyDerivationLabelLength { get { return default(int); } }
    [System.MonoTODOAttribute]
    public int MaximumKeyDerivationNonceLength { get { return default(int); } }
    [System.MonoTODOAttribute]
    public int MaximumKeyDerivationOffset { get { return default(int); } }
    public System.ServiceModel.Security.SecurityVersion SecurityVersion { get { return default(System.ServiceModel.Security.SecurityVersion); } }
    [System.MonoTODOAttribute]
    protected override bool CanReadKeyIdentifierClauseCore(System.Xml.XmlReader reader) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool CanReadKeyIdentifierCore(System.Xml.XmlReader reader) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool CanReadTokenCore(System.Xml.XmlReader reader) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool CanWriteKeyIdentifierClauseCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool CanWriteKeyIdentifierCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool CanWriteTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
    [System.MonoTODOAttribute]
    public virtual System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateKeyIdentifierClauseFromTokenXml(System.Xml.XmlElement tokenXml, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    protected virtual string GetTokenTypeUri(System.Type tokenType) { return default(string); }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClauseCore(System.Xml.XmlReader reader) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityKeyIdentifier ReadKeyIdentifierCore(System.Xml.XmlReader reader) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifier); }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityToken ReadTokenCore(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { return default(System.IdentityModel.Tokens.SecurityToken); }
    [System.MonoTODOAttribute]
    protected override void WriteKeyIdentifierClauseCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { }
    [System.MonoTODOAttribute]
    protected override void WriteKeyIdentifierCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { }
    [System.MonoTODOAttribute]
    protected override void WriteTokenCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
  }
  public sealed partial class X509CertificateInitiatorClientCredential {
    internal X509CertificateInitiatorClientCredential() { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } set { } }
    public void SetCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
    public void SetCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName) { }
  }
  public sealed partial class X509CertificateInitiatorServiceCredential {
    internal X509CertificateInitiatorServiceCredential() { }
    public System.ServiceModel.Security.X509ClientCertificateAuthentication Authentication { get { return default(System.ServiceModel.Security.X509ClientCertificateAuthentication); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } set { } }
    public void SetCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
    public void SetCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName) { }
  }
  public sealed partial class X509CertificateRecipientClientCredential {
    internal X509CertificateRecipientClientCredential() { }
    public System.ServiceModel.Security.X509ServiceCertificateAuthentication Authentication { get { return default(System.ServiceModel.Security.X509ServiceCertificateAuthentication); } }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 DefaultCertificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } set { } }
    public System.Collections.Generic.Dictionary<System.Uri, System.Security.Cryptography.X509Certificates.X509Certificate2> ScopedCertificates { get { return default(System.Collections.Generic.Dictionary<System.Uri, System.Security.Cryptography.X509Certificates.X509Certificate2>); } }
    public void SetDefaultCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
    public void SetDefaultCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName) { }
    public void SetScopedCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue, System.Uri targetService) { }
    public void SetScopedCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Uri targetService) { }
  }
  public sealed partial class X509CertificateRecipientServiceCredential {
    internal X509CertificateRecipientServiceCredential() { }
    public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { return default(System.Security.Cryptography.X509Certificates.X509Certificate2); } set { } }
    public void SetCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
    public void SetCertificate(string subjectName) { }
    public void SetCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName) { }
  }
  public enum X509CertificateValidationMode {
    ChainTrust = 2,
    Custom = 4,
    None = 0,
    PeerOrChainTrust = 3,
    PeerTrust = 1,
  }
  [System.MonoTODOAttribute]
  public partial class X509ClientCertificateAuthentication {
    internal X509ClientCertificateAuthentication() { }
    public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { return default(System.ServiceModel.Security.X509CertificateValidationMode); } set { } }
    public System.IdentityModel.Selectors.X509CertificateValidator CustomCertificateValidator { get { return default(System.IdentityModel.Selectors.X509CertificateValidator); } set { } }
    public bool IncludeWindowsGroups { get { return default(bool); } set { } }
    public bool MapClientCertificateToWindowsAccount { get { return default(bool); } set { } }
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } set { } }
    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
  }
  [System.MonoTODOAttribute]
  public partial class X509PeerCertificateAuthentication {
    internal X509PeerCertificateAuthentication() { }
    public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { return default(System.ServiceModel.Security.X509CertificateValidationMode); } set { } }
    public System.IdentityModel.Selectors.X509CertificateValidator CustomCertificateValidator { get { return default(System.IdentityModel.Selectors.X509CertificateValidator); } set { } }
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } set { } }
    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
  }
  [System.MonoTODOAttribute]
  public partial class X509ServiceCertificateAuthentication {
    internal X509ServiceCertificateAuthentication() { }
    public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { return default(System.ServiceModel.Security.X509CertificateValidationMode); } set { } }
    public System.IdentityModel.Selectors.X509CertificateValidator CustomCertificateValidator { get { return default(System.IdentityModel.Selectors.X509CertificateValidator); } set { } }
    public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { return default(System.Security.Cryptography.X509Certificates.X509RevocationMode); } set { } }
    public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { return default(System.Security.Cryptography.X509Certificates.StoreLocation); } set { } }
  }
}
namespace System.ServiceModel.Security.Tokens {
  public partial class BinarySecretSecurityToken : System.IdentityModel.Tokens.SecurityToken {
    public BinarySecretSecurityToken(System.Byte[] key) { }
    public BinarySecretSecurityToken(int keySizeInBits) { }
    public BinarySecretSecurityToken(string id, System.Byte[] key) { }
    protected BinarySecretSecurityToken(string id, System.Byte[] key, bool allowCrypto) { }
    public BinarySecretSecurityToken(string id, int keySizeInBits) { }
    protected BinarySecretSecurityToken(string id, int keySizeInBits, bool allowCrypto) { }
    public override string Id { get { return default(string); } }
    public int KeySize { get { return default(int); } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
    public System.Byte[] GetKeyBytes() { return default(System.Byte[]); }
  }
  public partial class ClaimTypeRequirement {
    public ClaimTypeRequirement(string claimType) { }
    public ClaimTypeRequirement(string claimType, bool isOptional) { }
    public string ClaimType { get { return default(string); } }
    public bool IsOptional { get { return default(bool); } }
  }
  public partial interface IIssuanceSecurityTokenAuthenticator {
    System.ServiceModel.Security.Tokens.IssuedSecurityTokenHandler IssuedSecurityTokenHandler { get; set; }
    System.ServiceModel.Security.Tokens.RenewedSecurityTokenHandler RenewedSecurityTokenHandler { get; set; }
  }
  public sealed partial class InitiatorServiceModelSecurityTokenRequirement : System.ServiceModel.Security.Tokens.ServiceModelSecurityTokenRequirement {
    public InitiatorServiceModelSecurityTokenRequirement() { }
    public System.ServiceModel.EndpointAddress TargetAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.Uri Via { get { return default(System.Uri); } set { } }
    public override string ToString() { return default(string); }
  }
  public partial interface ISecurityContextSecurityTokenCache {
    void AddContext(System.ServiceModel.Security.Tokens.SecurityContextSecurityToken token);
    void ClearContexts();
    System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityContextSecurityToken> GetAllContexts(System.Xml.UniqueId contextId);
    System.ServiceModel.Security.Tokens.SecurityContextSecurityToken GetContext(System.Xml.UniqueId contextId, System.Xml.UniqueId generation);
    void RemoveAllContexts(System.Xml.UniqueId contextId);
    void RemoveContext(System.Xml.UniqueId contextId, System.Xml.UniqueId generation);
    bool TryAddContext(System.ServiceModel.Security.Tokens.SecurityContextSecurityToken token);
    void UpdateContextCachingTime(System.ServiceModel.Security.Tokens.SecurityContextSecurityToken context, System.DateTime expirationTime);
  }
  public delegate void IssuedSecurityTokenHandler(System.IdentityModel.Tokens.SecurityToken issuedToken, System.ServiceModel.EndpointAddress tokenRequestor);
  public partial class IssuedSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters {
    public IssuedSecurityTokenParameters() { }
    protected IssuedSecurityTokenParameters(System.ServiceModel.Security.Tokens.IssuedSecurityTokenParameters source) { }
    public IssuedSecurityTokenParameters(string tokenType) { }
    public IssuedSecurityTokenParameters(string tokenType, System.ServiceModel.EndpointAddress issuerAddress) { }
    public IssuedSecurityTokenParameters(string tokenType, System.ServiceModel.EndpointAddress issuerAddress, System.ServiceModel.Channels.Binding issuerBinding) { }
    public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> AdditionalRequestParameters { get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlElement>); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.ClaimTypeRequirement> ClaimTypeRequirements { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.ClaimTypeRequirement>); } }
    protected override bool HasAsymmetricKey { get { return default(bool); } }
    public System.ServiceModel.EndpointAddress IssuerAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.Binding IssuerBinding { get { return default(System.ServiceModel.Channels.Binding); } set { } }
    public System.ServiceModel.EndpointAddress IssuerMetadataAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public int KeySize { get { return default(int); } set { } }
    public System.IdentityModel.Tokens.SecurityKeyType KeyType { get { return default(System.IdentityModel.Tokens.SecurityKeyType); } set { } }
    protected override bool SupportsClientAuthentication { get { return default(bool); } }
    protected override bool SupportsClientWindowsIdentity { get { return default(bool); } }
    protected override bool SupportsServerAuthentication { get { return default(bool); } }
    public string TokenType { get { return default(string); } set { } }
    protected override System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore() { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateKeyIdentifierClause(System.IdentityModel.Tokens.SecurityToken token, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> CreateRequestParameters(System.ServiceModel.MessageSecurityVersion messageSecurityVersion, System.IdentityModel.Selectors.SecurityTokenSerializer securityTokenSerializer) { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlElement>); }
    protected internal override void InitializeSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { }
    public override string ToString() { return default(string); }
  }
  public partial class IssuedSecurityTokenProvider : System.IdentityModel.Selectors.SecurityTokenProvider, System.ServiceModel.ICommunicationObject {
    public IssuedSecurityTokenProvider() { }
    public bool CacheIssuedTokens { get { return default(bool); } set { } }
    public virtual System.TimeSpan DefaultCloseTimeout { get { return default(System.TimeSpan); } }
    public virtual System.TimeSpan DefaultOpenTimeout { get { return default(System.TimeSpan); } }
    public System.ServiceModel.Security.IdentityVerifier IdentityVerifier { get { return default(System.ServiceModel.Security.IdentityVerifier); } set { } }
    public int IssuedTokenRenewalThresholdPercentage { get { return default(int); } set { } }
    public System.ServiceModel.EndpointAddress IssuerAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.ServiceModel.Channels.Binding IssuerBinding { get { return default(System.ServiceModel.Channels.Binding); } set { } }
    public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IEndpointBehavior> IssuerChannelBehaviors { get { return default(System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IEndpointBehavior>); } }
    public System.ServiceModel.Security.SecurityKeyEntropyMode KeyEntropyMode { get { return default(System.ServiceModel.Security.SecurityKeyEntropyMode); } set { } }
    public System.TimeSpan MaxIssuedTokenCachingTime { get { return default(System.TimeSpan); } set { } }
    public System.ServiceModel.MessageSecurityVersion MessageSecurityVersion { get { return default(System.ServiceModel.MessageSecurityVersion); } set { } }
    public System.ServiceModel.Security.SecurityAlgorithmSuite SecurityAlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public System.IdentityModel.Selectors.SecurityTokenSerializer SecurityTokenSerializer { get { return default(System.IdentityModel.Selectors.SecurityTokenSerializer); } set { } }
    public System.ServiceModel.CommunicationState State { get { return default(System.ServiceModel.CommunicationState); } }
    [System.MonoTODOAttribute("support it then")]
    public override bool SupportsTokenCancellation { get { return default(bool); } }
    public System.ServiceModel.EndpointAddress TargetAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> TokenRequestParameters { get { return default(System.Collections.ObjectModel.Collection<System.Xml.XmlElement>); } }
    public event System.EventHandler Closed { add { } remove { } }
    public event System.EventHandler Closing { add { } remove { } }
    public event System.EventHandler Faulted { add { } remove { } }
    public event System.EventHandler Opened { add { } remove { } }
    public event System.EventHandler Opening { add { } remove { } }
    [System.MonoTODOAttribute]
    public void Abort() { }
    public System.IAsyncResult BeginClose(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    public System.IAsyncResult BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    protected override System.IAsyncResult BeginGetTokenCore(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public System.IAsyncResult BeginOpen(System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    [System.MonoTODOAttribute]
    public System.IAsyncResult BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { return default(System.IAsyncResult); }
    public void Close() { }
    [System.MonoTODOAttribute]
    public void Close(System.TimeSpan timeout) { }
    public void Dispose() { }
    [System.MonoTODOAttribute]
    public void EndClose(System.IAsyncResult result) { }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityToken EndGetTokenCore(System.IAsyncResult result) { return default(System.IdentityModel.Tokens.SecurityToken); }
    [System.MonoTODOAttribute]
    public void EndOpen(System.IAsyncResult result) { }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout) { return default(System.IdentityModel.Tokens.SecurityToken); }
    public void Open() { }
    [System.MonoTODOAttribute]
    public void Open(System.TimeSpan timeout) { }
  }
  public partial class KerberosSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters {
    public KerberosSecurityTokenParameters() { }
    protected KerberosSecurityTokenParameters(System.ServiceModel.Security.Tokens.KerberosSecurityTokenParameters source) { }
    [System.MonoTODOAttribute]
    protected override bool HasAsymmetricKey { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected override bool SupportsClientAuthentication { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected override bool SupportsClientWindowsIdentity { get { return default(bool); } }
    [System.MonoTODOAttribute]
    protected override bool SupportsServerAuthentication { get { return default(bool); } }
    protected override System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore() { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateKeyIdentifierClause(System.IdentityModel.Tokens.SecurityToken token, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    protected internal override void InitializeSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { }
  }
  public sealed partial class RecipientServiceModelSecurityTokenRequirement : System.ServiceModel.Security.Tokens.ServiceModelSecurityTokenRequirement {
    public RecipientServiceModelSecurityTokenRequirement() { }
    public System.ServiceModel.AuditLogLocation AuditLogLocation { get { return default(System.ServiceModel.AuditLogLocation); } set { } }
    public System.Uri ListenUri { get { return default(System.Uri); } set { } }
    public System.ServiceModel.AuditLevel MessageAuthenticationAuditLevel { get { return default(System.ServiceModel.AuditLevel); } set { } }
    public bool SuppressAuditFailure { get { return default(bool); } set { } }
    public override string ToString() { return default(string); }
  }
  public delegate void RenewedSecurityTokenHandler(System.IdentityModel.Tokens.SecurityToken newSecurityToken, System.IdentityModel.Tokens.SecurityToken oldSecurityToken);
  public partial class RsaSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters {
    public RsaSecurityTokenParameters() { }
    protected RsaSecurityTokenParameters(System.ServiceModel.Security.Tokens.RsaSecurityTokenParameters source) { }
    protected override bool HasAsymmetricKey { get { return default(bool); } }
    protected override bool SupportsClientAuthentication { get { return default(bool); } }
    protected override bool SupportsClientWindowsIdentity { get { return default(bool); } }
    protected override bool SupportsServerAuthentication { get { return default(bool); } }
    protected override System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore() { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); }
    protected override System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateKeyIdentifierClause(System.IdentityModel.Tokens.SecurityToken token, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    protected internal override void InitializeSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { }
  }
  public partial class SecureConversationSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters {
    public SecureConversationSecurityTokenParameters() { }
    public SecureConversationSecurityTokenParameters(System.ServiceModel.Channels.SecurityBindingElement element) { }
    public SecureConversationSecurityTokenParameters(System.ServiceModel.Channels.SecurityBindingElement element, bool requireCancellation) { }
    public SecureConversationSecurityTokenParameters(System.ServiceModel.Channels.SecurityBindingElement element, bool requireCancellation, System.ServiceModel.Security.ChannelProtectionRequirements requirements) { }
    protected SecureConversationSecurityTokenParameters(System.ServiceModel.Security.Tokens.SecureConversationSecurityTokenParameters source) { }
    public System.ServiceModel.Security.ChannelProtectionRequirements BootstrapProtectionRequirements { get { return default(System.ServiceModel.Security.ChannelProtectionRequirements); } }
    public System.ServiceModel.Channels.SecurityBindingElement BootstrapSecurityBindingElement { get { return default(System.ServiceModel.Channels.SecurityBindingElement); } set { } }
    protected override bool HasAsymmetricKey { get { return default(bool); } }
    public bool RequireCancellation { get { return default(bool); } set { } }
    protected override bool SupportsClientAuthentication { get { return default(bool); } }
    protected override bool SupportsClientWindowsIdentity { get { return default(bool); } }
    protected override bool SupportsServerAuthentication { get { return default(bool); } }
    protected override System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore() { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateKeyIdentifierClause(System.IdentityModel.Tokens.SecurityToken token, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    [System.MonoTODOAttribute]
    protected internal override void InitializeSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { }
    public override string ToString() { return default(string); }
  }
  public partial class SecurityContextSecurityToken : System.IdentityModel.Tokens.SecurityToken {
    public SecurityContextSecurityToken(System.Xml.UniqueId contextId, System.Byte[] key, System.DateTime validFrom, System.DateTime validTo) { }
    public SecurityContextSecurityToken(System.Xml.UniqueId contextId, string id, System.Byte[] key, System.DateTime validFrom, System.DateTime validTo) { }
    public SecurityContextSecurityToken(System.Xml.UniqueId contextId, string id, System.Byte[] key, System.DateTime validFrom, System.DateTime validTo, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies) { }
    public SecurityContextSecurityToken(System.Xml.UniqueId contextId, string id, System.Byte[] key, System.DateTime validFrom, System.DateTime validTo, System.Xml.UniqueId keyGeneration, System.DateTime keyEffectiveTime, System.DateTime keyExpirationTime, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> AuthorizationPolicies { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); } }
    public System.Xml.UniqueId ContextId { get { return default(System.Xml.UniqueId); } }
    public override string Id { get { return default(string); } }
    public System.DateTime KeyEffectiveTime { get { return default(System.DateTime); } }
    public System.DateTime KeyExpirationTime { get { return default(System.DateTime); } }
    public System.Xml.UniqueId KeyGeneration { get { return default(System.Xml.UniqueId); } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
    public override bool CanCreateKeyIdentifierClause<T>() { return default(bool); }
    public static System.ServiceModel.Security.Tokens.SecurityContextSecurityToken CreateCookieSecurityContextToken(System.Xml.UniqueId contextId, string id, System.Byte[] key, System.DateTime validFrom, System.DateTime validTo, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies, System.ServiceModel.Security.SecurityStateEncoder securityStateEncoder) { return default(System.ServiceModel.Security.Tokens.SecurityContextSecurityToken); }
    public static System.ServiceModel.Security.Tokens.SecurityContextSecurityToken CreateCookieSecurityContextToken(System.Xml.UniqueId contextId, string id, System.Byte[] key, System.DateTime validFrom, System.DateTime validTo, System.Xml.UniqueId keyGeneration, System.DateTime keyEffectiveTime, System.DateTime keyExpirationTime, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies, System.ServiceModel.Security.SecurityStateEncoder securityStateEncoder) { return default(System.ServiceModel.Security.Tokens.SecurityContextSecurityToken); }
    public override T CreateKeyIdentifierClause<T>() { return default(T); }
    public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { return default(bool); }
    [System.MonoTODOAttribute]
    public override string ToString() { return default(string); }
  }
  public partial class SecurityContextSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator {
    public SecurityContextSecurityTokenAuthenticator() { }
    [System.MonoTODOAttribute]
    protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy>); }
  }
  public partial class SecurityContextSecurityTokenResolver : System.IdentityModel.Selectors.SecurityTokenResolver, System.ServiceModel.Security.Tokens.ISecurityContextSecurityTokenCache {
    public SecurityContextSecurityTokenResolver(int securityContextCacheCapacity, bool removeOldestTokensOnCacheFull) { }
    public bool RemoveOldestTokensOnCacheFull { get { return default(bool); } }
    public int SecurityContextTokenCacheCapacity { get { return default(int); } }
    public void AddContext(System.ServiceModel.Security.Tokens.SecurityContextSecurityToken token) { }
    public void ClearContexts() { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityContextSecurityToken> GetAllContexts(System.Xml.UniqueId contextId) { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityContextSecurityToken>); }
    public System.ServiceModel.Security.Tokens.SecurityContextSecurityToken GetContext(System.Xml.UniqueId contextId, System.Xml.UniqueId generation) { return default(System.ServiceModel.Security.Tokens.SecurityContextSecurityToken); }
    public void RemoveAllContexts(System.Xml.UniqueId contextId) { }
    public void RemoveContext(System.Xml.UniqueId contextId, System.Xml.UniqueId generation) { }
    public bool TryAddContext(System.ServiceModel.Security.Tokens.SecurityContextSecurityToken token) { return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool TryResolveSecurityKeyCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key) { key = default(System.IdentityModel.Tokens.SecurityKey); return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token) { token = default(System.IdentityModel.Tokens.SecurityToken); return default(bool); }
    [System.MonoTODOAttribute]
    protected override bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token) { token = default(System.IdentityModel.Tokens.SecurityToken); return default(bool); }
    [System.MonoTODOAttribute]
    public void UpdateContextCachingTime(System.ServiceModel.Security.Tokens.SecurityContextSecurityToken context, System.DateTime expirationTime) { }
  }
  public enum SecurityTokenInclusionMode {
    AlwaysToInitiator = 3,
    AlwaysToRecipient = 0,
    Never = 1,
    Once = 2,
  }
  public abstract partial class SecurityTokenParameters {
    protected SecurityTokenParameters() { }
    protected SecurityTokenParameters(System.ServiceModel.Security.Tokens.SecurityTokenParameters other) { }
    protected abstract bool HasAsymmetricKey { get; }
    public System.ServiceModel.Security.Tokens.SecurityTokenInclusionMode InclusionMode { get { return default(System.ServiceModel.Security.Tokens.SecurityTokenInclusionMode); } set { } }
    public System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle ReferenceStyle { get { return default(System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle); } set { } }
    public bool RequireDerivedKeys { get { return default(bool); } set { } }
    protected abstract bool SupportsClientAuthentication { get; }
    protected abstract bool SupportsClientWindowsIdentity { get; }
    protected abstract bool SupportsServerAuthentication { get; }
    public System.ServiceModel.Security.Tokens.SecurityTokenParameters Clone() { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); }
    protected abstract System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore();
    protected abstract System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateKeyIdentifierClause(System.IdentityModel.Tokens.SecurityToken token, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle);
    protected internal abstract void InitializeSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement);
    [System.MonoTODOAttribute]
    protected virtual bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityToken token, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle) { return default(bool); }
    public override string ToString() { return default(string); }
  }
  public enum SecurityTokenReferenceStyle {
    External = 1,
    Internal = 0,
  }
  public abstract partial class ServiceModelSecurityTokenRequirement : System.IdentityModel.Selectors.SecurityTokenRequirement {
    protected const string Namespace = "http://schemas.microsoft.com/ws/2006/05/servicemodel/securitytokenrequirement";
    protected ServiceModelSecurityTokenRequirement() { }
    public static string AuditLogLocationProperty { get { return default(string); } }
    public static string ChannelParametersCollectionProperty { get { return default(string); } }
    public static string DuplexClientLocalAddressProperty { get { return default(string); } }
    public static string EndpointFilterTableProperty { get { return default(string); } }
    public static string ExtendedProtectionPolicy { get { return default(string); } }
    public static string HttpAuthenticationSchemeProperty { get { return default(string); } }
    public bool IsInitiator { get { return default(bool); } }
    public static string IsInitiatorProperty { get { return default(string); } }
    public static string IsOutOfBandTokenProperty { get { return default(string); } }
    public static string IssuedSecurityTokenParametersProperty { get { return default(string); } }
    public System.ServiceModel.EndpointAddress IssuerAddress { get { return default(System.ServiceModel.EndpointAddress); } set { } }
    public static string IssuerAddressProperty { get { return default(string); } }
    public System.ServiceModel.Channels.Binding IssuerBinding { get { return default(System.ServiceModel.Channels.Binding); } set { } }
    public static string IssuerBindingContextProperty { get { return default(string); } }
    public static string IssuerBindingProperty { get { return default(string); } }
    public static string ListenUriProperty { get { return default(string); } }
    public static string MessageAuthenticationAuditLevelProperty { get { return default(string); } }
    public static string MessageDirectionProperty { get { return default(string); } }
    public System.IdentityModel.Selectors.SecurityTokenVersion MessageSecurityVersion { get { return default(System.IdentityModel.Selectors.SecurityTokenVersion); } set { } }
    public static string MessageSecurityVersionProperty { get { return default(string); } }
    public static string PrivacyNoticeUriProperty { get { return default(string); } }
    public static string PrivacyNoticeVersionProperty { get { return default(string); } }
    public System.ServiceModel.Channels.SecurityBindingElement SecureConversationSecurityBindingElement { get { return default(System.ServiceModel.Channels.SecurityBindingElement); } set { } }
    public static string SecureConversationSecurityBindingElementProperty { get { return default(string); } }
    public System.ServiceModel.Security.SecurityAlgorithmSuite SecurityAlgorithmSuite { get { return default(System.ServiceModel.Security.SecurityAlgorithmSuite); } set { } }
    public static string SecurityAlgorithmSuiteProperty { get { return default(string); } }
    public System.ServiceModel.Channels.SecurityBindingElement SecurityBindingElement { get { return default(System.ServiceModel.Channels.SecurityBindingElement); } set { } }
    public static string SecurityBindingElementProperty { get { return default(string); } }
    public static string SupportingTokenAttachmentModeProperty { get { return default(string); } }
    public static string SupportSecurityContextCancellationProperty { get { return default(string); } }
    public static string SuppressAuditFailureProperty { get { return default(string); } }
    public static string TargetAddressProperty { get { return default(string); } }
    public string TransportScheme { get { return default(string); } set { } }
    public static string TransportSchemeProperty { get { return default(string); } }
    public static string ViaProperty { get { return default(string); } }
  }
  public static partial class ServiceModelSecurityTokenTypes {
    public static string AnonymousSslnego { get { return default(string); } }
    public static string MutualSslnego { get { return default(string); } }
    public static string SecureConversation { get { return default(string); } }
    public static string SecurityContext { get { return default(string); } }
    public static string Spnego { get { return default(string); } }
    public static string SspiCredential { get { return default(string); } }
  }
  public partial class SslSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters {
    public SslSecurityTokenParameters() { }
    public SslSecurityTokenParameters(bool requireClientCertificate) { }
    public SslSecurityTokenParameters(bool requireClientCertificate, bool requireCancellation) { }
    protected SslSecurityTokenParameters(System.ServiceModel.Security.Tokens.SslSecurityTokenParameters source) { }
    protected override bool HasAsymmetricKey { get { return default(bool); } }
    public bool RequireCancellation { get { return default(bool); } set { } }
    public bool RequireClientCertificate { get { return default(bool); } set { } }
    protected override bool SupportsClientAuthentication { get { return default(bool); } }
    protected override bool SupportsClientWindowsIdentity { get { return default(bool); } }
    protected override bool SupportsServerAuthentication { get { return default(bool); } }
    protected override System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore() { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); }
    protected override System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateKeyIdentifierClause(System.IdentityModel.Tokens.SecurityToken token, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    protected internal override void InitializeSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { }
    public override string ToString() { return default(string); }
  }
  public partial class SspiSecurityToken : System.IdentityModel.Tokens.SecurityToken {
    [System.MonoTODOAttribute]
    public SspiSecurityToken(System.Net.NetworkCredential cred, bool extractGroupsForWindowsAccounts, bool allowUnauthenticatedCallers) { }
    [System.MonoTODOAttribute]
    public SspiSecurityToken(System.Security.Principal.TokenImpersonationLevel impersonationLevel, bool allowNtlm, System.Net.NetworkCredential cred) { }
    [System.MonoTODOAttribute]
    public override string Id { get { return default(string); } }
    [System.MonoTODOAttribute]
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    [System.MonoTODOAttribute]
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
  }
  public partial class SspiSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters {
    public SspiSecurityTokenParameters() { }
    public SspiSecurityTokenParameters(bool requireCancellation) { }
    protected SspiSecurityTokenParameters(System.ServiceModel.Security.Tokens.SspiSecurityTokenParameters source) { }
    protected override bool HasAsymmetricKey { get { return default(bool); } }
    public bool RequireCancellation { get { return default(bool); } set { } }
    protected override bool SupportsClientAuthentication { get { return default(bool); } }
    protected override bool SupportsClientWindowsIdentity { get { return default(bool); } }
    protected override bool SupportsServerAuthentication { get { return default(bool); } }
    protected override System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore() { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); }
    [System.MonoTODOAttribute]
    protected override System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateKeyIdentifierClause(System.IdentityModel.Tokens.SecurityToken token, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    [System.MonoTODOAttribute]
    protected internal override void InitializeSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { }
    public override string ToString() { return default(string); }
  }
  public partial class SupportingTokenParameters {
    public SupportingTokenParameters() { }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters> Endorsing { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters>); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters> Signed { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters>); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters> SignedEncrypted { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters>); } }
    public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters> SignedEndorsing { get { return default(System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters>); } }
    public System.ServiceModel.Security.Tokens.SupportingTokenParameters Clone() { return default(System.ServiceModel.Security.Tokens.SupportingTokenParameters); }
    public void SetKeyDerivation(bool requireDerivedKeys) { }
    public override string ToString() { return default(string); }
  }
  public partial class UserNameSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters {
    public UserNameSecurityTokenParameters() { }
    protected UserNameSecurityTokenParameters(System.ServiceModel.Security.Tokens.UserNameSecurityTokenParameters source) { }
    protected override bool HasAsymmetricKey { get { return default(bool); } }
    protected override bool SupportsClientAuthentication { get { return default(bool); } }
    protected override bool SupportsClientWindowsIdentity { get { return default(bool); } }
    protected override bool SupportsServerAuthentication { get { return default(bool); } }
    protected override System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore() { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); }
    protected override System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateKeyIdentifierClause(System.IdentityModel.Tokens.SecurityToken token, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    protected internal override void InitializeSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { }
  }
  public partial class WrappedKeySecurityToken : System.IdentityModel.Tokens.SecurityToken {
    public WrappedKeySecurityToken(string id, System.Byte[] keyToWrap, string wrappingAlgorithm, System.IdentityModel.Tokens.SecurityToken wrappingToken, System.IdentityModel.Tokens.SecurityKeyIdentifier wrappingTokenReference) { }
    public override string Id { get { return default(string); } }
    public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey>); } }
    public override System.DateTime ValidFrom { get { return default(System.DateTime); } }
    public override System.DateTime ValidTo { get { return default(System.DateTime); } }
    public string WrappingAlgorithm { get { return default(string); } }
    public System.IdentityModel.Tokens.SecurityToken WrappingToken { get { return default(System.IdentityModel.Tokens.SecurityToken); } }
    public System.IdentityModel.Tokens.SecurityKeyIdentifier WrappingTokenReference { get { return default(System.IdentityModel.Tokens.SecurityKeyIdentifier); } }
    [System.MonoTODOAttribute]
    public override bool CanCreateKeyIdentifierClause<T>() { return default(bool); }
    [System.MonoTODOAttribute]
    public override T CreateKeyIdentifierClause<T>() { return default(T); }
    public System.Byte[] GetWrappedKey() { return default(System.Byte[]); }
    public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { return default(bool); }
  }
  public enum X509KeyIdentifierClauseType {
    Any = 0,
    IssuerSerial = 2,
    RawDataKeyIdentifier = 4,
    SubjectKeyIdentifier = 3,
    Thumbprint = 1,
  }
  public partial class X509SecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters {
    public X509SecurityTokenParameters() { }
    public X509SecurityTokenParameters(System.ServiceModel.Security.Tokens.X509KeyIdentifierClauseType x509ReferenceStyle) { }
    public X509SecurityTokenParameters(System.ServiceModel.Security.Tokens.X509KeyIdentifierClauseType x509ReferenceStyle, System.ServiceModel.Security.Tokens.SecurityTokenInclusionMode inclusionMode) { }
    protected X509SecurityTokenParameters(System.ServiceModel.Security.Tokens.X509SecurityTokenParameters source) { }
    protected override bool HasAsymmetricKey { get { return default(bool); } }
    protected override bool SupportsClientAuthentication { get { return default(bool); } }
    protected override bool SupportsClientWindowsIdentity { get { return default(bool); } }
    protected override bool SupportsServerAuthentication { get { return default(bool); } }
    public System.ServiceModel.Security.Tokens.X509KeyIdentifierClauseType X509ReferenceStyle { get { return default(System.ServiceModel.Security.Tokens.X509KeyIdentifierClauseType); } set { } }
    protected override System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore() { return default(System.ServiceModel.Security.Tokens.SecurityTokenParameters); }
    protected override System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateKeyIdentifierClause(System.IdentityModel.Tokens.SecurityToken token, System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle referenceStyle) { return default(System.IdentityModel.Tokens.SecurityKeyIdentifierClause); }
    protected internal override void InitializeSecurityTokenRequirement(System.IdentityModel.Selectors.SecurityTokenRequirement requirement) { }
    public override string ToString() { return default(string); }
  }
}
