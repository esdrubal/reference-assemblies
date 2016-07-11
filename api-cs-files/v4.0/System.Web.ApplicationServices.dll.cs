namespace System.Web.Configuration {
  public enum MembershipPasswordCompatibilityMode {
    Framework20 = 0,
    Framework40 = 1,
  }
}
namespace System.Web.Security {
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public enum MembershipCreateStatus {
    DuplicateEmail = 7,
    DuplicateProviderUserKey = 10,
    DuplicateUserName = 6,
    InvalidAnswer = 4,
    InvalidEmail = 5,
    InvalidPassword = 2,
    InvalidProviderUserKey = 9,
    InvalidQuestion = 3,
    InvalidUserName = 1,
    ProviderError = 11,
    Success = 0,
    UserRejected = 8,
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class MembershipCreateUserException : System.Exception {
    public MembershipCreateUserException() { }
    protected MembershipCreateUserException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MembershipCreateUserException(string message) { }
    public MembershipCreateUserException(string message, System.Exception innerException) { }
    public MembershipCreateUserException(System.Web.Security.MembershipCreateStatus statusCode) { }
    public System.Web.Security.MembershipCreateStatus StatusCode { get { return default(System.Web.Security.MembershipCreateStatus); } }
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class MembershipPasswordException : System.Exception {
    public MembershipPasswordException() { }
    protected MembershipPasswordException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public MembershipPasswordException(string message) { }
    public MembershipPasswordException(string message, System.Exception innerException) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public enum MembershipPasswordFormat {
    Clear = 0,
    Encrypted = 2,
    Hashed = 1,
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public abstract partial class MembershipProvider : System.Configuration.Provider.ProviderBase {
    protected MembershipProvider() { }
    public abstract string ApplicationName { get; set; }
    public abstract bool EnablePasswordReset { get; }
    public abstract bool EnablePasswordRetrieval { get; }
    public abstract int MaxInvalidPasswordAttempts { get; }
    public abstract int MinRequiredNonAlphanumericCharacters { get; }
    public abstract int MinRequiredPasswordLength { get; }
    public abstract int PasswordAttemptWindow { get; }
    public abstract System.Web.Security.MembershipPasswordFormat PasswordFormat { get; }
    public abstract string PasswordStrengthRegularExpression { get; }
    public abstract bool RequiresQuestionAndAnswer { get; }
    public abstract bool RequiresUniqueEmail { get; }
    public event System.Web.Security.MembershipValidatePasswordEventHandler ValidatingPassword { add { } remove { } }
    public abstract bool ChangePassword(string name, string oldPwd, string newPwd);
    public abstract bool ChangePasswordQuestionAndAnswer(string name, string password, string newPwdQuestion, string newPwdAnswer);
    public abstract System.Web.Security.MembershipUser CreateUser(string username, string password, string email, string pwdQuestion, string pwdAnswer, bool isApproved, object providerUserKey, out System.Web.Security.MembershipCreateStatus status);
    protected virtual System.Byte[] DecryptPassword(System.Byte[] encodedPassword) { return default(System.Byte[]); }
    public abstract bool DeleteUser(string name, bool deleteAllRelatedData);
    protected virtual System.Byte[] EncryptPassword(System.Byte[] password) { return default(System.Byte[]); }
    [System.MonoTODOAttribute("Discover what actually is 4.0 password compatibility mode.")]
    protected virtual System.Byte[] EncryptPassword(System.Byte[] password, System.Web.Configuration.MembershipPasswordCompatibilityMode legacyPasswordCompatibilityMode) { return default(System.Byte[]); }
    public abstract System.Web.Security.MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords);
    public abstract System.Web.Security.MembershipUserCollection FindUsersByName(string nameToMatch, int pageIndex, int pageSize, out int totalRecords);
    public abstract System.Web.Security.MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords);
    public abstract int GetNumberOfUsersOnline();
    public abstract string GetPassword(string name, string answer);
    public abstract System.Web.Security.MembershipUser GetUser(object providerUserKey, bool userIsOnline);
    public abstract System.Web.Security.MembershipUser GetUser(string name, bool userIsOnline);
    public abstract string GetUserNameByEmail(string email);
    protected virtual void OnValidatingPassword(System.Web.Security.ValidatePasswordEventArgs args) { }
    public abstract string ResetPassword(string name, string answer);
    public abstract bool UnlockUser(string userName);
    public abstract void UpdateUser(System.Web.Security.MembershipUser user);
    public abstract bool ValidateUser(string name, string password);
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public sealed partial class MembershipProviderCollection : System.Configuration.Provider.ProviderCollection {
    public MembershipProviderCollection() { }
    public new System.Web.Security.MembershipProvider this[string name] { get { return default(System.Web.Security.MembershipProvider); } }
    public override void Add(System.Configuration.Provider.ProviderBase provider) { }
    public void CopyTo(System.Web.Security.MembershipProvider[] array, int index) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public partial class MembershipUser {
    protected MembershipUser() { }
    public MembershipUser(string providerName, string name, object providerUserKey, string email, string passwordQuestion, string comment, bool isApproved, bool isLockedOut, System.DateTime creationDate, System.DateTime lastLoginDate, System.DateTime lastActivityDate, System.DateTime lastPasswordChangedDate, System.DateTime lastLockoutDate) { }
    public virtual string Comment { get { return default(string); } set { } }
    public virtual System.DateTime CreationDate { get { return default(System.DateTime); } }
    public virtual string Email { get { return default(string); } set { } }
    public virtual bool IsApproved { get { return default(bool); } set { } }
    public virtual bool IsLockedOut { get { return default(bool); } }
    public virtual bool IsOnline { get { return default(bool); } }
    public virtual System.DateTime LastActivityDate { get { return default(System.DateTime); } set { } }
    public virtual System.DateTime LastLockoutDate { get { return default(System.DateTime); } }
    public virtual System.DateTime LastLoginDate { get { return default(System.DateTime); } set { } }
    public virtual System.DateTime LastPasswordChangedDate { get { return default(System.DateTime); } }
    public virtual string PasswordQuestion { get { return default(string); } }
    public virtual string ProviderName { get { return default(string); } }
    public virtual object ProviderUserKey { get { return default(object); } }
    public virtual string UserName { get { return default(string); } }
    public virtual bool ChangePassword(string oldPassword, string newPassword) { return default(bool); }
    public virtual bool ChangePasswordQuestionAndAnswer(string password, string newPasswordQuestion, string newPasswordAnswer) { return default(bool); }
    public virtual string GetPassword() { return default(string); }
    public virtual string GetPassword(string answer) { return default(string); }
    public virtual string ResetPassword() { return default(string); }
    public virtual string ResetPassword(string answer) { return default(string); }
    public override string ToString() { return default(string); }
    public virtual bool UnlockUser() { return default(bool); }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public sealed partial class MembershipUserCollection : System.Collections.ICollection, System.Collections.IEnumerable {
    public MembershipUserCollection() { }
    public int Count { get { return default(int); } }
    public bool IsSynchronized { get { return default(bool); } }
    public System.Web.Security.MembershipUser this[string name] { get { return default(System.Web.Security.MembershipUser); } }
    public object SyncRoot { get { return default(object); } }
    public void Add(System.Web.Security.MembershipUser user) { }
    public void Clear() { }
    public void CopyTo(System.Web.Security.MembershipUser[] array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public void Remove(string name) { }
    public void SetReadOnly() { }
    void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public delegate void MembershipValidatePasswordEventHandler(object sender, System.Web.Security.ValidatePasswordEventArgs e);
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public abstract partial class RoleProvider : System.Configuration.Provider.ProviderBase {
    protected RoleProvider() { }
    public abstract string ApplicationName { get; set; }
    public abstract void AddUsersToRoles(System.String[] usernames, System.String[] rolenames);
    public abstract void CreateRole(string rolename);
    public abstract bool DeleteRole(string rolename, bool throwOnPopulatedRole);
    public abstract System.String[] FindUsersInRole(string roleName, string usernameToMatch);
    public abstract System.String[] GetAllRoles();
    public abstract System.String[] GetRolesForUser(string username);
    public abstract System.String[] GetUsersInRole(string rolename);
    public abstract bool IsUserInRole(string username, string rolename);
    public abstract void RemoveUsersFromRoles(System.String[] usernames, System.String[] rolenames);
    public abstract bool RoleExists(string rolename);
  }
  [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web, Version=2.0.0.0, Culture=Neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  public sealed partial class ValidatePasswordEventArgs : System.EventArgs {
    public ValidatePasswordEventArgs(string userName, string password, bool isNewUser) { }
    public bool Cancel { get { return default(bool); } set { } }
    public System.Exception FailureInformation { get { return default(System.Exception); } set { } }
    public bool IsNewUser { get { return default(bool); } }
    public string Password { get { return default(string); } }
    public string UserName { get { return default(string); } }
  }
}
