namespace System.Web.ApplicationServices {
  public partial class ApplicationServicesHostFactory : System.ServiceModel.Activation.ServiceHostFactory {
    public ApplicationServicesHostFactory() { }
    protected override System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { return default(System.ServiceModel.ServiceHost); }
  }
  public partial class AuthenticatingEventArgs : System.EventArgs {
    internal AuthenticatingEventArgs() { }
    public bool Authenticated { get { return default(bool); } set { } }
    public bool AuthenticationIsComplete { get { return default(bool); } set { } }
    public string CustomCredential { get { return default(string); } }
    public string Password { get { return default(string); } }
    public string UserName { get { return default(string); } }
  }
  [System.ServiceModel.Activation.AspNetCompatibilityRequirementsAttribute(RequirementsMode=(System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode)(2))]
  [System.ServiceModel.ServiceBehaviorAttribute(Namespace="http://asp.net/ApplicationServices/v200", InstanceContextMode=(System.ServiceModel.InstanceContextMode)(2), ConcurrencyMode=(System.ServiceModel.ConcurrencyMode)(2))]
  [System.ServiceModel.ServiceContractAttribute(Namespace="http://asp.net/ApplicationServices/v200")]
  public partial class AuthenticationService {
    public AuthenticationService() { }
    public static event System.EventHandler<System.Web.ApplicationServices.AuthenticatingEventArgs> Authenticating { add { } remove { } }
    public static event System.EventHandler<System.Web.ApplicationServices.CreatingCookieEventArgs> CreatingCookie { add { } remove { } }
    [System.ServiceModel.OperationContractAttribute]
    public bool IsLoggedIn() { return default(bool); }
    [System.ServiceModel.OperationContractAttribute]
    public bool Login(string username, string password, string customCredential, bool isPersistent) { return default(bool); }
    [System.ServiceModel.OperationContractAttribute]
    public void Logout() { }
    [System.ServiceModel.OperationContractAttribute]
    public bool ValidateUser(string username, string password, string customCredential) { return default(bool); }
  }
  public partial class CreatingCookieEventArgs : System.EventArgs {
    internal CreatingCookieEventArgs() { }
    public bool CookieIsSet { get { return default(bool); } set { } }
    public string CustomCredential { get { return default(string); } }
    public bool IsPersistent { get { return default(bool); } }
    public string Password { get { return default(string); } }
    public string UserName { get { return default(string); } }
  }
  public static partial class KnownTypesProvider {
    public static System.Type[] GetKnownTypes(System.Reflection.ICustomAttributeProvider knownTypeAttributeTarget) { return default(System.Type[]); }
  }
  [System.Runtime.Serialization.DataContractAttribute]
  public partial class ProfilePropertyMetadata : System.Runtime.Serialization.IExtensibleDataObject {
    public ProfilePropertyMetadata() { }
    [System.Runtime.Serialization.DataMemberAttribute]
    public bool AllowAnonymousAccess { get { return default(bool); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string DefaultValue { get { return default(string); } set { } }
    public System.Runtime.Serialization.ExtensionDataObject ExtensionData { get { return default(System.Runtime.Serialization.ExtensionDataObject); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public bool IsReadOnly { get { return default(bool); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string PropertyName { get { return default(string); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public int SerializeAs { get { return default(int); } set { } }
    [System.Runtime.Serialization.DataMemberAttribute]
    public string TypeName { get { return default(string); } set { } }
  }
  [System.ServiceModel.Activation.AspNetCompatibilityRequirementsAttribute(RequirementsMode=(System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode)(2))]
  [System.ServiceModel.ServiceBehaviorAttribute(Namespace="http://asp.net/ApplicationServices/v200", InstanceContextMode=(System.ServiceModel.InstanceContextMode)(2), ConcurrencyMode=(System.ServiceModel.ConcurrencyMode)(2))]
  [System.ServiceModel.ServiceContractAttribute(Namespace="http://asp.net/ApplicationServices/v200")]
  [System.ServiceModel.ServiceKnownTypeAttribute("GetKnownTypes", typeof(System.Web.ApplicationServices.KnownTypesProvider))]
  public partial class ProfileService {
    public ProfileService() { }
    public static event System.EventHandler<System.Web.ApplicationServices.ValidatingPropertiesEventArgs> ValidatingProperties { add { } remove { } }
    [System.ServiceModel.OperationContractAttribute]
    public System.Collections.Generic.Dictionary<System.String, System.Object> GetAllPropertiesForCurrentUser(bool authenticatedUserOnly) { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); }
    [System.ServiceModel.OperationContractAttribute]
    public System.Collections.Generic.Dictionary<System.String, System.Object> GetPropertiesForCurrentUser(System.Collections.Generic.IEnumerable<System.String> properties, bool authenticatedUserOnly) { return default(System.Collections.Generic.Dictionary<System.String, System.Object>); }
    [System.ServiceModel.OperationContractAttribute]
    public System.Web.ApplicationServices.ProfilePropertyMetadata[] GetPropertiesMetadata() { return default(System.Web.ApplicationServices.ProfilePropertyMetadata[]); }
    [System.ServiceModel.OperationContractAttribute]
    public System.Collections.ObjectModel.Collection<System.String> SetPropertiesForCurrentUser(System.Collections.Generic.IDictionary<System.String, System.Object> values, bool authenticatedUserOnly) { return default(System.Collections.ObjectModel.Collection<System.String>); }
  }
  [System.ServiceModel.Activation.AspNetCompatibilityRequirementsAttribute(RequirementsMode=(System.ServiceModel.Activation.AspNetCompatibilityRequirementsMode)(2))]
  [System.ServiceModel.ServiceBehaviorAttribute(Namespace="http://asp.net/ApplicationServices/v200", InstanceContextMode=(System.ServiceModel.InstanceContextMode)(2), ConcurrencyMode=(System.ServiceModel.ConcurrencyMode)(2))]
  [System.ServiceModel.ServiceContractAttribute(Namespace="http://asp.net/ApplicationServices/v200")]
  public partial class RoleService {
    public RoleService() { }
    public static event System.EventHandler<System.Web.ApplicationServices.SelectingProviderEventArgs> SelectingProvider { add { } remove { } }
    [System.ServiceModel.OperationContractAttribute]
    public System.String[] GetRolesForCurrentUser() { return default(System.String[]); }
    [System.ServiceModel.OperationContractAttribute]
    public bool IsCurrentUserInRole(string role) { return default(bool); }
  }
  public partial class SelectingProviderEventArgs : System.EventArgs {
    internal SelectingProviderEventArgs() { }
    public string ProviderName { get { return default(string); } set { } }
    public System.Security.Principal.IPrincipal User { get { return default(System.Security.Principal.IPrincipal); } }
  }
  public partial class ValidatingPropertiesEventArgs : System.EventArgs {
    internal ValidatingPropertiesEventArgs() { }
    public System.Collections.ObjectModel.Collection<System.String> FailedProperties { get { return default(System.Collections.ObjectModel.Collection<System.String>); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Properties { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
  }
}
namespace System.Web.ClientServices {
  public partial class ClientFormsIdentity : System.IDisposable, System.Security.Principal.IIdentity {
    public ClientFormsIdentity(string name, string password, System.Web.Security.MembershipProvider provider, string authenticationType, bool isAuthenticated, System.Net.CookieContainer authenticationCookies) { }
    public System.Net.CookieContainer AuthenticationCookies { get { return default(System.Net.CookieContainer); } }
    public string AuthenticationType { get { return default(string); } }
    public bool IsAuthenticated { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public System.Web.Security.MembershipProvider Provider { get { return default(System.Web.Security.MembershipProvider); } }
    public void Dispose() { }
    protected virtual void Dispose(bool disposing) { }
    public void RevalidateUser() { }
  }
  public partial class ClientRolePrincipal : System.Security.Principal.IPrincipal {
    public ClientRolePrincipal(System.Security.Principal.IIdentity identity) { }
    public System.Security.Principal.IIdentity Identity { get { return default(System.Security.Principal.IIdentity); } }
    public bool IsInRole(string role) { return default(bool); }
  }
  public static partial class ConnectivityStatus {
    public static bool IsOffline { get { return default(bool); } set { } }
  }
}
namespace System.Web.ClientServices.Providers {
  public partial class ClientFormsAuthenticationCredentials {
    public ClientFormsAuthenticationCredentials(string username, string password, bool rememberMe) { }
    public string Password { get { return default(string); } set { } }
    public bool RememberMe { get { return default(bool); } set { } }
    public string UserName { get { return default(string); } set { } }
  }
  public partial class ClientFormsAuthenticationMembershipProvider : System.Web.Security.MembershipProvider {
    public ClientFormsAuthenticationMembershipProvider() { }
    public override string ApplicationName { get { return default(string); } set { } }
    public override bool EnablePasswordReset { get { return default(bool); } }
    public override bool EnablePasswordRetrieval { get { return default(bool); } }
    public override int MaxInvalidPasswordAttempts { get { return default(int); } }
    public override int MinRequiredNonAlphanumericCharacters { get { return default(int); } }
    public override int MinRequiredPasswordLength { get { return default(int); } }
    public override int PasswordAttemptWindow { get { return default(int); } }
    public override System.Web.Security.MembershipPasswordFormat PasswordFormat { get { return default(System.Web.Security.MembershipPasswordFormat); } }
    public override string PasswordStrengthRegularExpression { get { return default(string); } }
    public override bool RequiresQuestionAndAnswer { get { return default(bool); } }
    public override bool RequiresUniqueEmail { get { return default(bool); } }
    public string ServiceUri { get { return default(string); } set { } }
    public event System.EventHandler<System.Web.ClientServices.Providers.UserValidatedEventArgs> UserValidated { add { } remove { } }
    public override bool ChangePassword(string username, string oldPassword, string newPassword) { return default(bool); }
    public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer) { return default(bool); }
    public override System.Web.Security.MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out System.Web.Security.MembershipCreateStatus status) { status = default(System.Web.Security.MembershipCreateStatus); return default(System.Web.Security.MembershipUser); }
    public override bool DeleteUser(string username, bool deleteAllRelatedData) { return default(bool); }
    public override System.Web.Security.MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); return default(System.Web.Security.MembershipUserCollection); }
    public override System.Web.Security.MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); return default(System.Web.Security.MembershipUserCollection); }
    public override System.Web.Security.MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); return default(System.Web.Security.MembershipUserCollection); }
    public override int GetNumberOfUsersOnline() { return default(int); }
    public override string GetPassword(string username, string answer) { return default(string); }
    public override System.Web.Security.MembershipUser GetUser(object providerUserKey, bool userIsOnline) { return default(System.Web.Security.MembershipUser); }
    public override System.Web.Security.MembershipUser GetUser(string username, bool userIsOnline) { return default(System.Web.Security.MembershipUser); }
    public override string GetUserNameByEmail(string email) { return default(string); }
    public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config) { }
    public void Logout() { }
    public override string ResetPassword(string username, string answer) { return default(string); }
    public override bool UnlockUser(string username) { return default(bool); }
    public override void UpdateUser(System.Web.Security.MembershipUser user) { }
    public override bool ValidateUser(string username, string password) { return default(bool); }
    public bool ValidateUser(string username, string password, bool rememberMe) { return default(bool); }
    public static bool ValidateUser(string username, string password, string serviceUri) { return default(bool); }
  }
  public partial class ClientRoleProvider : System.Web.Security.RoleProvider {
    public ClientRoleProvider() { }
    public override string ApplicationName { get { return default(string); } set { } }
    public string ServiceUri { get { return default(string); } set { } }
    public override void AddUsersToRoles(System.String[] usernames, System.String[] roleNames) { }
    public override void CreateRole(string roleName) { }
    public override bool DeleteRole(string roleName, bool throwOnPopulatedRole) { return default(bool); }
    public override System.String[] FindUsersInRole(string roleName, string usernameToMatch) { return default(System.String[]); }
    public override System.String[] GetAllRoles() { return default(System.String[]); }
    public override System.String[] GetRolesForUser(string username) { return default(System.String[]); }
    public override System.String[] GetUsersInRole(string roleName) { return default(System.String[]); }
    public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config) { }
    public override bool IsUserInRole(string username, string roleName) { return default(bool); }
    public override void RemoveUsersFromRoles(System.String[] usernames, System.String[] roleNames) { }
    public void ResetCache() { }
    public override bool RoleExists(string roleName) { return default(bool); }
  }
  [System.Security.SecurityCriticalAttribute]
  [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
  public partial class ClientSettingsProvider : System.Configuration.SettingsProvider, System.Configuration.IApplicationSettingsProvider {
    public ClientSettingsProvider() { }
    public override string ApplicationName { [System.Security.SecuritySafeCriticalAttribute]get { return default(string); } [System.Security.SecuritySafeCriticalAttribute]set { } }
    public static string ServiceUri { get { return default(string); } set { } }
    public event System.EventHandler<System.Web.ClientServices.Providers.SettingsSavedEventArgs> SettingsSaved { add { } remove { } }
    [System.Security.SecuritySafeCriticalAttribute]
    public System.Configuration.SettingsPropertyValue GetPreviousVersion(System.Configuration.SettingsContext context, System.Configuration.SettingsProperty property) { return default(System.Configuration.SettingsPropertyValue); }
    public static System.Configuration.SettingsPropertyCollection GetPropertyMetadata(string serviceUri) { return default(System.Configuration.SettingsPropertyCollection); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override System.Configuration.SettingsPropertyValueCollection GetPropertyValues(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection propertyCollection) { return default(System.Configuration.SettingsPropertyValueCollection); }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void Initialize(string name, System.Collections.Specialized.NameValueCollection config) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Reset(System.Configuration.SettingsContext context) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void SetPropertyValues(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyValueCollection propertyValueCollection) { }
    [System.Security.SecuritySafeCriticalAttribute]
    public void Upgrade(System.Configuration.SettingsContext context, System.Configuration.SettingsPropertyCollection properties) { }
  }
  public partial class ClientWindowsAuthenticationMembershipProvider : System.Web.Security.MembershipProvider {
    public ClientWindowsAuthenticationMembershipProvider() { }
    public override string ApplicationName { get { return default(string); } set { } }
    public override bool EnablePasswordReset { get { return default(bool); } }
    public override bool EnablePasswordRetrieval { get { return default(bool); } }
    public override int MaxInvalidPasswordAttempts { get { return default(int); } }
    public override int MinRequiredNonAlphanumericCharacters { get { return default(int); } }
    public override int MinRequiredPasswordLength { get { return default(int); } }
    public override int PasswordAttemptWindow { get { return default(int); } }
    public override System.Web.Security.MembershipPasswordFormat PasswordFormat { get { return default(System.Web.Security.MembershipPasswordFormat); } }
    public override string PasswordStrengthRegularExpression { get { return default(string); } }
    public override bool RequiresQuestionAndAnswer { get { return default(bool); } }
    public override bool RequiresUniqueEmail { get { return default(bool); } }
    public override bool ChangePassword(string username, string oldPassword, string newPassword) { return default(bool); }
    public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer) { return default(bool); }
    public override System.Web.Security.MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, object providerUserKey, out System.Web.Security.MembershipCreateStatus status) { status = default(System.Web.Security.MembershipCreateStatus); return default(System.Web.Security.MembershipUser); }
    public override bool DeleteUser(string username, bool deleteAllRelatedData) { return default(bool); }
    public override System.Web.Security.MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); return default(System.Web.Security.MembershipUserCollection); }
    public override System.Web.Security.MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); return default(System.Web.Security.MembershipUserCollection); }
    public override System.Web.Security.MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords) { totalRecords = default(int); return default(System.Web.Security.MembershipUserCollection); }
    public override int GetNumberOfUsersOnline() { return default(int); }
    public override string GetPassword(string username, string answer) { return default(string); }
    public override System.Web.Security.MembershipUser GetUser(object providerUserKey, bool userIsOnline) { return default(System.Web.Security.MembershipUser); }
    public override System.Web.Security.MembershipUser GetUser(string username, bool userIsOnline) { return default(System.Web.Security.MembershipUser); }
    public override string GetUserNameByEmail(string email) { return default(string); }
    public void Logout() { }
    public override string ResetPassword(string username, string answer) { return default(string); }
    public override bool UnlockUser(string username) { return default(bool); }
    public override void UpdateUser(System.Web.Security.MembershipUser user) { }
    public override bool ValidateUser(string username, string password) { return default(bool); }
  }
  public partial interface IClientFormsAuthenticationCredentialsProvider {
    System.Web.ClientServices.Providers.ClientFormsAuthenticationCredentials GetCredentials();
  }
  public partial class SettingsSavedEventArgs : System.EventArgs {
    public SettingsSavedEventArgs(System.Collections.Generic.IEnumerable<System.String> failedSettingsList) { }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.String> FailedSettingsList { get { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.String>); } }
  }
  public partial class UserValidatedEventArgs : System.EventArgs {
    public UserValidatedEventArgs(string username) { }
    public string UserName { get { return default(string); } }
  }
}
namespace System.Web.Compilation {
  public partial interface IWcfReferenceReceiveContextInformation {
    void ReceiveImportContextInformation(System.Collections.Generic.IDictionary<System.String, System.Byte[]> serviceReferenceExtensionFileContents, System.IServiceProvider serviceProvider);
  }
  [System.Security.SecurityCriticalAttribute]
  public partial class WCFBuildProvider : System.Web.Compilation.BuildProvider {
    public WCFBuildProvider() { }
    [System.Security.SecuritySafeCriticalAttribute]
    public override void GenerateCode(System.Web.Compilation.AssemblyBuilder assemblyBuilder) { }
  }
}
namespace System.Web.Configuration {
  public partial class Converter : System.Configuration.ConfigurationElement {
    public Converter() { }
    [System.Configuration.ConfigurationPropertyAttribute("name", IsRequired=true, IsKey=true, DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string Name { get { return default(string); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("type", IsRequired=true, DefaultValue="")]
    [System.Configuration.StringValidatorAttribute(MinLength=1)]
    public string Type { get { return default(string); } set { } }
  }
  [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Web.Configuration.Converter))]
  public partial class ConvertersCollection : System.Configuration.ConfigurationElementCollection {
    public ConvertersCollection() { }
    public System.Web.Configuration.Converter this[int index] { get { return default(System.Web.Configuration.Converter); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    public void Add(System.Web.Configuration.Converter converter) { }
    public void Clear() { }
    protected override System.Configuration.ConfigurationElement CreateNewElement() { return default(System.Configuration.ConfigurationElement); }
    protected override object GetElementKey(System.Configuration.ConfigurationElement element) { return default(object); }
    public void Remove(System.Web.Configuration.Converter converter) { }
  }
  public sealed partial class ScriptingAuthenticationServiceSection : System.Configuration.ConfigurationSection {
    public ScriptingAuthenticationServiceSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue=false)]
    public bool Enabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("requireSSL", DefaultValue=false)]
    public bool RequireSSL { get { return default(bool); } set { } }
  }
  public sealed partial class ScriptingJsonSerializationSection : System.Configuration.ConfigurationSection {
    public ScriptingJsonSerializationSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("converters", IsKey=true, DefaultValue="")]
    public System.Web.Configuration.ConvertersCollection Converters { get { return default(System.Web.Configuration.ConvertersCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("maxJsonLength", DefaultValue=102400)]
    public int MaxJsonLength { get { return default(int); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("recursionLimit", DefaultValue=100)]
    public int RecursionLimit { get { return default(int); } set { } }
  }
  public sealed partial class ScriptingProfileServiceSection : System.Configuration.ConfigurationSection {
    public ScriptingProfileServiceSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue=false)]
    public bool Enabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
    [System.Configuration.ConfigurationPropertyAttribute("readAccessProperties", DefaultValue=null)]
    public System.String[] ReadAccessProperties { get { return default(System.String[]); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("writeAccessProperties", DefaultValue=null)]
    public System.String[] WriteAccessProperties { get { return default(System.String[]); } set { } }
  }
  public sealed partial class ScriptingRoleServiceSection : System.Configuration.ConfigurationSection {
    public ScriptingRoleServiceSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("enabled", DefaultValue=false)]
    public bool Enabled { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class ScriptingScriptResourceHandlerSection : System.Configuration.ConfigurationSection {
    public ScriptingScriptResourceHandlerSection() { }
    [System.Configuration.ConfigurationPropertyAttribute("enableCaching", DefaultValue=true)]
    public bool EnableCaching { get { return default(bool); } set { } }
    [System.Configuration.ConfigurationPropertyAttribute("enableCompression", DefaultValue=true)]
    public bool EnableCompression { get { return default(bool); } set { } }
    protected override System.Configuration.ConfigurationPropertyCollection Properties { get { return default(System.Configuration.ConfigurationPropertyCollection); } }
  }
  public sealed partial class ScriptingSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public ScriptingSectionGroup() { }
    [System.Configuration.ConfigurationPropertyAttribute("scriptResourceHandler")]
    public System.Web.Configuration.ScriptingScriptResourceHandlerSection ScriptResourceHandler { get { return default(System.Web.Configuration.ScriptingScriptResourceHandlerSection); } }
    [System.Configuration.ConfigurationPropertyAttribute("webServices")]
    public System.Web.Configuration.ScriptingWebServicesSectionGroup WebServices { get { return default(System.Web.Configuration.ScriptingWebServicesSectionGroup); } }
  }
  public sealed partial class ScriptingWebServicesSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public ScriptingWebServicesSectionGroup() { }
    [System.Configuration.ConfigurationPropertyAttribute("authenticationService")]
    public System.Web.Configuration.ScriptingAuthenticationServiceSection AuthenticationService { get { return default(System.Web.Configuration.ScriptingAuthenticationServiceSection); } }
    [System.Configuration.ConfigurationPropertyAttribute("jsonSerialization")]
    public System.Web.Configuration.ScriptingJsonSerializationSection JsonSerialization { get { return default(System.Web.Configuration.ScriptingJsonSerializationSection); } }
    [System.Configuration.ConfigurationPropertyAttribute("profileService")]
    public System.Web.Configuration.ScriptingProfileServiceSection ProfileService { get { return default(System.Web.Configuration.ScriptingProfileServiceSection); } }
    [System.Configuration.ConfigurationPropertyAttribute("roleService")]
    public System.Web.Configuration.ScriptingRoleServiceSection RoleService { get { return default(System.Web.Configuration.ScriptingRoleServiceSection); } }
  }
  public sealed partial class SystemWebExtensionsSectionGroup : System.Configuration.ConfigurationSectionGroup {
    public SystemWebExtensionsSectionGroup() { }
    [System.Configuration.ConfigurationPropertyAttribute("scripting")]
    public System.Web.Configuration.ScriptingSectionGroup Scripting { get { return default(System.Web.Configuration.ScriptingSectionGroup); } }
  }
}
namespace System.Web.DynamicData {
  public enum DynamicDataSourceOperation {
    ContextCreate = 4,
    Delete = 0,
    Insert = 1,
    Select = 2,
    Update = 3,
  }
  public partial class DynamicValidatorEventArgs : System.EventArgs {
    public DynamicValidatorEventArgs(System.Exception exception, System.Web.DynamicData.DynamicDataSourceOperation operation) { }
    public System.Exception Exception { get { return default(System.Exception); } }
    public System.Web.DynamicData.DynamicDataSourceOperation Operation { get { return default(System.Web.DynamicData.DynamicDataSourceOperation); } }
  }
  public partial interface IDynamicDataSource : System.Web.UI.IDataSource {
    bool AutoGenerateWhereClause { get; set; }
    System.Type ContextType { get; set; }
    bool EnableDelete { get; set; }
    bool EnableInsert { get; set; }
    bool EnableUpdate { get; set; }
    string EntitySetName { get; set; }
    string Where { get; set; }
    System.Web.UI.WebControls.ParameterCollection WhereParameters { get; }
    event System.EventHandler<System.Web.DynamicData.DynamicValidatorEventArgs> Exception;
  }
  public partial interface IDynamicValidatorException {
    System.Collections.Generic.IDictionary<System.String, System.Exception> InnerExceptions { get; }
  }
}
namespace System.Web.Handlers {
  public partial class ScriptModule : System.Web.IHttpModule {
    public ScriptModule() { }
    protected virtual void Dispose() { }
    protected virtual void Init(System.Web.HttpApplication app) { }
    void System.Web.IHttpModule.Dispose() { }
    void System.Web.IHttpModule.Init(System.Web.HttpApplication context) { }
  }
  public partial class ScriptResourceHandler : System.Web.IHttpHandler {
    public ScriptResourceHandler() { }
    protected virtual bool IsReusable { get { return default(bool); } }
    bool System.Web.IHttpHandler.IsReusable { get { return default(bool); } }
    [System.Security.SecuritySafeCriticalAttribute]
    protected virtual void ProcessRequest(System.Web.HttpContext context) { }
    void System.Web.IHttpHandler.ProcessRequest(System.Web.HttpContext context) { }
  }
}
namespace System.Web.Management {
  public partial class WebServiceErrorEvent : System.Web.Management.WebRequestErrorEvent {
    protected internal WebServiceErrorEvent(string message, object eventSource, System.Exception exception) : base (default(string), default(object), default(int), default(System.Exception)) { }
    public static int WebServiceErrorEventCode { get { return default(int); } }
  }
}
namespace System.Web.Query.Dynamic {
  public abstract partial class DynamicClass {
    protected DynamicClass() { }
    public override string ToString() { return default(string); }
  }
  public partial class ParseException : System.Exception {
    public ParseException(string message, int position) { }
    public int Position { get { return default(int); } }
    public override string ToString() { return default(string); }
  }
}
namespace System.Web.Script {
  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=false)]
  public partial class AjaxFrameworkAssemblyAttribute : System.Attribute {
    public AjaxFrameworkAssemblyAttribute() { }
    protected internal virtual System.Reflection.Assembly GetDefaultAjaxFrameworkAssembly(System.Reflection.Assembly currentAssembly) { return default(System.Reflection.Assembly); }
  }
}
namespace System.Web.Script.Serialization {
  public abstract partial class JavaScriptConverter {
    protected JavaScriptConverter() { }
    public abstract System.Collections.Generic.IEnumerable<System.Type> SupportedTypes { get; }
    public abstract object Deserialize(System.Collections.Generic.IDictionary<System.String, System.Object> dictionary, System.Type type, System.Web.Script.Serialization.JavaScriptSerializer serializer);
    public abstract System.Collections.Generic.IDictionary<System.String, System.Object> Serialize(object obj, System.Web.Script.Serialization.JavaScriptSerializer serializer);
  }
  public partial class JavaScriptSerializer {
    public JavaScriptSerializer() { }
    public JavaScriptSerializer(System.Web.Script.Serialization.JavaScriptTypeResolver resolver) { }
    public int MaxJsonLength { get { return default(int); } set { } }
    public int RecursionLimit { get { return default(int); } set { } }
    public object ConvertToType(object obj, System.Type targetType) { return default(object); }
    public T ConvertToType<T>(object obj) { return default(T); }
    public object Deserialize(string input, System.Type targetType) { return default(object); }
    public T Deserialize<T>(string input) { return default(T); }
    public object DeserializeObject(string input) { return default(object); }
    public void RegisterConverters(System.Collections.Generic.IEnumerable<System.Web.Script.Serialization.JavaScriptConverter> converters) { }
    public string Serialize(object obj) { return default(string); }
    public void Serialize(object obj, System.Text.StringBuilder output) { }
  }
  public abstract partial class JavaScriptTypeResolver {
    protected JavaScriptTypeResolver() { }
    public abstract System.Type ResolveType(string id);
    public abstract string ResolveTypeId(System.Type type);
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
  public sealed partial class ScriptIgnoreAttribute : System.Attribute {
    public ScriptIgnoreAttribute() { }
    public bool ApplyToOverrides { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public partial class SimpleTypeResolver : System.Web.Script.Serialization.JavaScriptTypeResolver {
    public SimpleTypeResolver() { }
    public override System.Type ResolveType(string id) { return default(System.Type); }
    public override string ResolveTypeId(System.Type type) { return default(string); }
  }
}
namespace System.Web.Script.Services {
  [System.AttributeUsageAttribute((System.AttributeTargets)(1092), AllowMultiple=true)]
  public sealed partial class GenerateScriptTypeAttribute : System.Attribute {
    public GenerateScriptTypeAttribute(System.Type type) { }
    public string ScriptTypeId { get { return default(string); } set { } }
    public System.Type Type { get { return default(System.Type); } }
  }
  public static partial class ProxyGenerator {
    public static string GetClientProxyScript(System.Type type, string path, bool debug) { return default(string); }
    public static string GetClientProxyScript(System.Type type, string path, bool debug, System.ServiceModel.Description.ServiceEndpoint serviceEndpoint) { return default(string); }
  }
  public enum ResponseFormat {
    Json = 0,
    Xml = 1,
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
  public sealed partial class ScriptMethodAttribute : System.Attribute {
    public ScriptMethodAttribute() { }
    public System.Web.Script.Services.ResponseFormat ResponseFormat { get { return default(System.Web.Script.Services.ResponseFormat); } set { } }
    public bool UseHttpGet { get { return default(bool); } set { } }
    public bool XmlSerializeString { get { return default(bool); } set { } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1028))]
  public sealed partial class ScriptServiceAttribute : System.Attribute {
    public ScriptServiceAttribute() { }
  }
}
namespace System.Web.UI {
  public enum AjaxFrameworkMode {
    Disabled = 1,
    Enabled = 0,
    Explicit = 2,
  }
  public partial class AsyncPostBackErrorEventArgs : System.EventArgs {
    public AsyncPostBackErrorEventArgs(System.Exception exception) { }
    public System.Exception Exception { get { return default(System.Exception); } }
  }
  public partial class AsyncPostBackTrigger : System.Web.UI.UpdatePanelControlTrigger {
    public AsyncPostBackTrigger() { }
    [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.AsyncPostBackTriggerControlIDConverter, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public new string ControlID { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.AsyncPostBackTriggerEventNameConverter, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.Web.UI.ResourceDescriptionAttribute("AsyncPostBackTrigger_EventName")]
    public string EventName { get { return default(string); } set { } }
    protected internal override bool HasTriggered() { return default(bool); }
    protected internal override void Initialize() { }
    public void OnEvent(object sender, System.EventArgs e) { }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Path")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.EmptyStringExpandableObjectConverter))]
  public partial class AuthenticationServiceManager {
    public AuthenticationServiceManager() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ApplicationServiceManager_Path")]
    [System.Web.UI.UrlPropertyAttribute]
    public string Path { get { return default(string); } set { } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Path")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.EmptyStringExpandableObjectConverter))]
  public partial class CompositeScriptReference : System.Web.UI.ScriptReferenceBase {
    public CompositeScriptReference() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.CollectionEditorBase, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("CompositeScriptReference_Scripts")]
    public System.Web.UI.ScriptReferenceCollection Scripts { get { return default(System.Web.UI.ScriptReferenceCollection); } }
    protected internal override string GetUrl(System.Web.UI.ScriptManager scriptManager, bool zip) { return default(string); }
    protected internal override bool IsAjaxFrameworkScript(System.Web.UI.ScriptManager scriptManager) { return default(bool); }
    [System.ObsoleteAttribute("Use IsAjaxFrameworkScript(ScriptManager)")]
    protected internal override bool IsFromSystemWebExtensions() { return default(bool); }
  }
  public partial class CompositeScriptReferenceEventArgs : System.EventArgs {
    public CompositeScriptReferenceEventArgs(System.Web.UI.CompositeScriptReference compositeScript) { }
    public System.Web.UI.CompositeScriptReference CompositeScript { get { return default(System.Web.UI.CompositeScriptReference); } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("TargetControlID")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.ExtenderControlDesigner, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.ComponentModel.ToolboxItemAttribute("System.Web.UI.Design.ExtenderControlToolboxItem, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Web.UI.NonVisualControlAttribute]
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public abstract partial class ExtenderControl : System.Web.UI.Control, System.Web.UI.IExtenderControl {
    protected ExtenderControl() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.IDReferencePropertyAttribute]
    [System.Web.UI.ResourceDescriptionAttribute("ExtenderControl_TargetControlID")]
    public string TargetControlID { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool Visible { get { return default(bool); } set { } }
    protected abstract System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors(System.Web.UI.Control targetControl);
    protected abstract System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences();
    protected internal override void OnPreRender(System.EventArgs e) { }
    protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> System.Web.UI.IExtenderControl.GetScriptDescriptors(System.Web.UI.Control targetControl) { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor>); }
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> System.Web.UI.IExtenderControl.GetScriptReferences() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference>); }
  }
  public partial class HistoryEventArgs : System.EventArgs {
    public HistoryEventArgs(System.Collections.Specialized.NameValueCollection state) { }
    public System.Collections.Specialized.NameValueCollection State { get { return default(System.Collections.Specialized.NameValueCollection); } }
  }
  public partial interface IExtenderControl {
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors(System.Web.UI.Control targetControl);
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences();
  }
  public partial interface IScriptControl {
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors();
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences();
  }
  public partial class PostBackTrigger : System.Web.UI.UpdatePanelControlTrigger {
    public PostBackTrigger() { }
    [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.PostBackTriggerControlIDConverter, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public new string ControlID { get { return default(string); } set { } }
    protected internal override bool HasTriggered() { return default(bool); }
    protected internal override void Initialize() { }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Path")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.EmptyStringExpandableObjectConverter))]
  public partial class ProfileServiceManager {
    public ProfileServiceManager() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.StringArrayConverter))]
    [System.Web.UI.ResourceDescriptionAttribute("ProfileServiceManager_LoadProperties")]
    public System.String[] LoadProperties { get { return default(System.String[]); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ApplicationServiceManager_Path")]
    [System.Web.UI.UrlPropertyAttribute]
    public string Path { get { return default(string); } set { } }
  }
  public sealed partial class RegisteredArrayDeclaration {
    internal RegisteredArrayDeclaration() { }
    public System.Web.UI.Control Control { get { return default(System.Web.UI.Control); } }
    public string Name { get { return default(string); } }
    public string Value { get { return default(string); } }
  }
  public sealed partial class RegisteredDisposeScript {
    internal RegisteredDisposeScript() { }
    public System.Web.UI.Control Control { get { return default(System.Web.UI.Control); } }
    public string Script { get { return default(string); } }
  }
  public sealed partial class RegisteredExpandoAttribute {
    internal RegisteredExpandoAttribute() { }
    public System.Web.UI.Control Control { get { return default(System.Web.UI.Control); } }
    public string ControlId { get { return default(string); } }
    public bool Encode { get { return default(bool); } }
    public string Name { get { return default(string); } }
    public string Value { get { return default(string); } }
  }
  public sealed partial class RegisteredHiddenField {
    internal RegisteredHiddenField() { }
    public System.Web.UI.Control Control { get { return default(System.Web.UI.Control); } }
    public string InitialValue { get { return default(string); } }
    public string Name { get { return default(string); } }
  }
  public sealed partial class RegisteredScript {
    internal RegisteredScript() { }
    public bool AddScriptTags { get { return default(bool); } }
    public System.Web.UI.Control Control { get { return default(System.Web.UI.Control); } }
    public string Key { get { return default(string); } }
    public string Script { get { return default(string); } }
    public System.Web.UI.RegisteredScriptType ScriptType { get { return default(System.Web.UI.RegisteredScriptType); } }
    public System.Type Type { get { return default(System.Type); } }
    public string Url { get { return default(string); } }
  }
  public enum RegisteredScriptType {
    ClientScriptBlock = 1,
    ClientScriptInclude = 0,
    ClientStartupScript = 2,
    OnSubmitStatement = 3,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Path")]
  [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.EmptyStringExpandableObjectConverter))]
  public partial class RoleServiceManager {
    public RoleServiceManager() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("RoleServiceManager_LoadRoles")]
    public bool LoadRoles { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ApplicationServiceManager_Path")]
    [System.Web.UI.UrlPropertyAttribute]
    public string Path { get { return default(string); } set { } }
  }
  public partial class ScriptBehaviorDescriptor : System.Web.UI.ScriptComponentDescriptor {
    public ScriptBehaviorDescriptor(string type, string elementID) : base (default(string)) { }
    public override string ClientID { get { return default(string); } }
    public string ElementID { get { return default(string); } }
    public string Name { get { return default(string); } set { } }
    protected internal override string GetScript() { return default(string); }
  }
  public partial class ScriptComponentDescriptor : System.Web.UI.ScriptDescriptor {
    public ScriptComponentDescriptor(string type) { }
    public virtual string ClientID { get { return default(string); } }
    public virtual string ID { get { return default(string); } set { } }
    public string Type { get { return default(string); } set { } }
    public void AddComponentProperty(string name, string componentID) { }
    public void AddElementProperty(string name, string elementID) { }
    public void AddEvent(string name, string handler) { }
    public void AddProperty(string name, object value) { }
    public void AddScriptProperty(string name, string script) { }
    protected internal override string GetScript() { return default(string); }
  }
  public abstract partial class ScriptControl : System.Web.UI.WebControls.WebControl, System.Web.UI.IScriptControl {
    protected ScriptControl() { }
    protected abstract System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors();
    protected abstract System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences();
    protected internal override void OnPreRender(System.EventArgs e) { }
    protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> System.Web.UI.IScriptControl.GetScriptDescriptors() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor>); }
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> System.Web.UI.IScriptControl.GetScriptReferences() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference>); }
  }
  public partial class ScriptControlDescriptor : System.Web.UI.ScriptComponentDescriptor {
    public ScriptControlDescriptor(string type, string elementID) : base (default(string)) { }
    public override string ClientID { get { return default(string); } }
    public string ElementID { get { return default(string); } }
    public override string ID { get { return default(string); } set { } }
  }
  public abstract partial class ScriptDescriptor {
    protected ScriptDescriptor() { }
    protected internal abstract string GetScript();
  }
  [System.ComponentModel.DefaultPropertyAttribute("Scripts")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.ScriptManagerDesigner, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(EmbeddedResourceFinder), "System.Web.Resources.ScriptManager.bmp")]
  [System.Web.UI.NonVisualControlAttribute]
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public partial class ScriptManager : System.Web.UI.Control, System.Web.UI.IPostBackDataHandler, System.Web.UI.IPostBackEventHandler {
    public ScriptManager() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_AjaxFrameworkAssembly")]
    public virtual System.Reflection.Assembly AjaxFrameworkAssembly { get { return default(System.Reflection.Assembly); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.AjaxFrameworkMode)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_AjaxFrameworkMode")]
    public System.Web.UI.AjaxFrameworkMode AjaxFrameworkMode { get { return default(System.Web.UI.AjaxFrameworkMode); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_AllowCustomErrorsRedirect")]
    public bool AllowCustomErrorsRedirect { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_AsyncPostBackErrorMessage")]
    public string AsyncPostBackErrorMessage { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public string AsyncPostBackSourceElementID { get { return default(string); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(90)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_AsyncPostBackTimeout")]
    public int AsyncPostBackTimeout { get { return default(int); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_AuthenticationService")]
    public System.Web.UI.AuthenticationServiceManager AuthenticationService { get { return default(System.Web.UI.AuthenticationServiceManager); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_ClientNavigateHandler")]
    public string ClientNavigateHandler { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_CompositeScript")]
    public System.Web.UI.CompositeScriptReference CompositeScript { get { return default(System.Web.UI.CompositeScriptReference); } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.UrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_EmptyPageUrl")]
    [System.Web.UI.UrlPropertyAttribute]
    public virtual string EmptyPageUrl { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_EnableCdn")]
    public bool EnableCdn { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_EnableCdnFallback")]
    public bool EnableCdnFallback { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_EnableHistory")]
    public bool EnableHistory { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_EnablePageMethods")]
    public bool EnablePageMethods { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_EnablePartialRendering")]
    public bool EnablePartialRendering { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_EnableScriptGlobalization")]
    public bool EnableScriptGlobalization { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_EnableScriptLocalization")]
    public bool EnableScriptLocalization { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_EnableSecureHistoryState")]
    public bool EnableSecureHistoryState { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsDebuggingEnabled { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsInAsyncPostBack { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsNavigating { get { return default(bool); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_LoadScriptsBeforeUI")]
    public bool LoadScriptsBeforeUI { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_ProfileService")]
    public System.Web.UI.ProfileServiceManager ProfileService { get { return default(System.Web.UI.ProfileServiceManager); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_RoleService")]
    public System.Web.UI.RoleServiceManager RoleService { get { return default(System.Web.UI.RoleServiceManager); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.ScriptMode)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_ScriptMode")]
    public System.Web.UI.ScriptMode ScriptMode { get { return default(System.Web.UI.ScriptMode); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ObsoleteAttribute("This property is obsolete. Set the Path property on each individual ScriptReference instead.")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_ScriptPath")]
    public string ScriptPath { get { return default(string); } set { } }
    public static System.Web.UI.ScriptResourceMapping ScriptResourceMapping { get { return default(System.Web.UI.ScriptResourceMapping); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.CollectionEditorBase, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_Scripts")]
    public System.Web.UI.ScriptReferenceCollection Scripts { get { return default(System.Web.UI.ScriptReferenceCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.ServiceReferenceCollectionEditor, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_Services")]
    public System.Web.UI.ServiceReferenceCollection Services { get { return default(System.Web.UI.ServiceReferenceCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(true)]
    public bool SupportsPartialRendering { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool Visible { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_AsyncPostBackError")]
    public event System.EventHandler<System.Web.UI.AsyncPostBackErrorEventArgs> AsyncPostBackError { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_Navigate")]
    public event System.EventHandler<System.Web.UI.HistoryEventArgs> Navigate { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_ResolveCompositeScriptReference")]
    public event System.EventHandler<System.Web.UI.CompositeScriptReferenceEventArgs> ResolveCompositeScriptReference { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_ResolveScriptReference")]
    public event System.EventHandler<System.Web.UI.ScriptReferenceEventArgs> ResolveScriptReference { add { } remove { } }
    public void AddHistoryPoint(System.Collections.Specialized.NameValueCollection state, string title) { }
    public void AddHistoryPoint(string key, string value) { }
    public void AddHistoryPoint(string key, string value, string title) { }
    public static System.Web.UI.ScriptManager GetCurrent(System.Web.UI.Page page) { return default(System.Web.UI.ScriptManager); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredArrayDeclaration> GetRegisteredArrayDeclarations() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredArrayDeclaration>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredScript> GetRegisteredClientScriptBlocks() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredScript>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredDisposeScript> GetRegisteredDisposeScripts() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredDisposeScript>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredExpandoAttribute> GetRegisteredExpandoAttributes() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredExpandoAttribute>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredHiddenField> GetRegisteredHiddenFields() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredHiddenField>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredScript> GetRegisteredOnSubmitStatements() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredScript>); }
    public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredScript> GetRegisteredStartupScripts() { return default(System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.RegisteredScript>); }
    public string GetStateString() { return default(string); }
    protected virtual bool LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection) { return default(bool); }
    protected internal virtual void OnAsyncPostBackError(System.Web.UI.AsyncPostBackErrorEventArgs e) { }
    protected internal override void OnInit(System.EventArgs e) { }
    protected internal override void OnPreRender(System.EventArgs e) { }
    protected virtual void OnResolveCompositeScriptReference(System.Web.UI.CompositeScriptReferenceEventArgs e) { }
    protected virtual void OnResolveScriptReference(System.Web.UI.ScriptReferenceEventArgs e) { }
    protected virtual void RaisePostBackEvent(string eventArgument) { }
    protected virtual void RaisePostDataChangedEvent() { }
    public static void RegisterArrayDeclaration(System.Web.UI.Control control, string arrayName, string arrayValue) { }
    public static void RegisterArrayDeclaration(System.Web.UI.Page page, string arrayName, string arrayValue) { }
    public void RegisterAsyncPostBackControl(System.Web.UI.Control control) { }
    public static void RegisterClientScriptBlock(System.Web.UI.Control control, System.Type type, string key, string script, bool addScriptTags) { }
    public static void RegisterClientScriptBlock(System.Web.UI.Page page, System.Type type, string key, string script, bool addScriptTags) { }
    public static void RegisterClientScriptInclude(System.Web.UI.Control control, System.Type type, string key, string url) { }
    public static void RegisterClientScriptInclude(System.Web.UI.Page page, System.Type type, string key, string url) { }
    public static void RegisterClientScriptResource(System.Web.UI.Control control, System.Type type, string resourceName) { }
    public static void RegisterClientScriptResource(System.Web.UI.Page page, System.Type type, string resourceName) { }
    public void RegisterDataItem(System.Web.UI.Control control, string dataItem) { }
    public void RegisterDataItem(System.Web.UI.Control control, string dataItem, bool isJsonSerialized) { }
    public void RegisterDispose(System.Web.UI.Control control, string disposeScript) { }
    public static void RegisterExpandoAttribute(System.Web.UI.Control control, string controlId, string attributeName, string attributeValue, bool encode) { }
    public void RegisterExtenderControl<TExtenderControl>(TExtenderControl extenderControl, System.Web.UI.Control targetControl) where TExtenderControl : System.Web.UI.Control, System.Web.UI.IExtenderControl { }
    public static void RegisterHiddenField(System.Web.UI.Control control, string hiddenFieldName, string hiddenFieldInitialValue) { }
    public static void RegisterHiddenField(System.Web.UI.Page page, string hiddenFieldName, string hiddenFieldInitialValue) { }
    public static void RegisterNamedClientScriptResource(System.Web.UI.Control control, string resourceName) { }
    public static void RegisterNamedClientScriptResource(System.Web.UI.Page page, string resourceName) { }
    public static void RegisterOnSubmitStatement(System.Web.UI.Control control, System.Type type, string key, string script) { }
    public static void RegisterOnSubmitStatement(System.Web.UI.Page page, System.Type type, string key, string script) { }
    public void RegisterPostBackControl(System.Web.UI.Control control) { }
    public void RegisterScriptControl<TScriptControl>(TScriptControl scriptControl) where TScriptControl : System.Web.UI.Control, System.Web.UI.IScriptControl { }
    public void RegisterScriptDescriptors(System.Web.UI.IExtenderControl extenderControl) { }
    public void RegisterScriptDescriptors(System.Web.UI.IScriptControl scriptControl) { }
    public static void RegisterStartupScript(System.Web.UI.Control control, System.Type type, string key, string script, bool addScriptTags) { }
    public static void RegisterStartupScript(System.Web.UI.Page page, System.Type type, string key, string script, bool addScriptTags) { }
    protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public void SetFocus(string clientID) { }
    public void SetFocus(System.Web.UI.Control control) { }
    bool System.Web.UI.IPostBackDataHandler.LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection) { return default(bool); }
    void System.Web.UI.IPostBackDataHandler.RaisePostDataChangedEvent() { }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Scripts")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.ScriptManagerProxyDesigner, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(EmbeddedResourceFinder), "System.Web.Resources.ScriptManagerProxy.bmp")]
  [System.Web.UI.NonVisualControlAttribute]
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public partial class ScriptManagerProxy : System.Web.UI.Control {
    public ScriptManagerProxy() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_AuthenticationService")]
    public System.Web.UI.AuthenticationServiceManager AuthenticationService { get { return default(System.Web.UI.AuthenticationServiceManager); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_CompositeScript")]
    public System.Web.UI.CompositeScriptReference CompositeScript { get { return default(System.Web.UI.CompositeScriptReference); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_ProfileService")]
    public System.Web.UI.ProfileServiceManager ProfileService { get { return default(System.Web.UI.ProfileServiceManager); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_RoleService")]
    public System.Web.UI.RoleServiceManager RoleService { get { return default(System.Web.UI.RoleServiceManager); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.CollectionEditorBase, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_Scripts")]
    public System.Web.UI.ScriptReferenceCollection Scripts { get { return default(System.Web.UI.ScriptReferenceCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.ServiceReferenceCollectionEditor, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_Services")]
    public System.Web.UI.ServiceReferenceCollection Services { get { return default(System.Web.UI.ServiceReferenceCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool Visible { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptManager_Navigate")]
    public event System.EventHandler<System.Web.UI.HistoryEventArgs> Navigate { add { } remove { } }
    protected internal override void OnInit(System.EventArgs e) { }
  }
  public enum ScriptMode {
    Auto = 0,
    Debug = 2,
    Inherit = 1,
    Release = 3,
  }
  [System.ComponentModel.DefaultPropertyAttribute("Path")]
  public partial class ScriptReference : System.Web.UI.ScriptReferenceBase {
    public ScriptReference() { }
    public ScriptReference(string path) { }
    public ScriptReference(string name, string assembly) { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptReference_Assembly")]
    public string Assembly { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.ObsoleteAttribute("This property is obsolete. Instead of using ScriptManager.ScriptPath, set the Path property on each individual ScriptReference.")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptReference_IgnoreScriptPath")]
    public bool IgnoreScriptPath { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptReference_Name")]
    public string Name { get { return default(string); } set { } }
    protected internal override string GetUrl(System.Web.UI.ScriptManager scriptManager, bool zip) { return default(string); }
    protected internal override bool IsAjaxFrameworkScript(System.Web.UI.ScriptManager scriptManager) { return default(bool); }
    [System.ObsoleteAttribute("This method is obsolete. Use IsAjaxFrameworkScript(ScriptManager) instead.")]
    protected internal override bool IsFromSystemWebExtensions() { return default(bool); }
    public override string ToString() { return default(string); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Path")]
  public abstract partial class ScriptReferenceBase {
    protected ScriptReferenceBase() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ObsoleteAttribute("NotifyScriptLoaded is no longer required in script references.")]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptReference_NotifyScriptLoaded")]
    public bool NotifyScriptLoaded { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptReference_Path")]
    [System.Web.UI.UrlPropertyAttribute("*.js")]
    public string Path { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.StringArrayConverter))]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptReference_ResourceUICultures")]
    public System.String[] ResourceUICultures { get { return default(System.String[]); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.ScriptMode)(0))]
    [System.ComponentModel.NotifyParentPropertyAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ScriptReference_ScriptMode")]
    public System.Web.UI.ScriptMode ScriptMode { get { return default(System.Web.UI.ScriptMode); } set { } }
    protected internal abstract string GetUrl(System.Web.UI.ScriptManager scriptManager, bool zip);
    protected internal virtual bool IsAjaxFrameworkScript(System.Web.UI.ScriptManager scriptManager) { return default(bool); }
    [System.ObsoleteAttribute("Use IsAjaxFrameworkScript(ScriptManager)")]
    protected internal abstract bool IsFromSystemWebExtensions();
    protected static string ReplaceExtension(string pathOrName) { return default(string); }
  }
  public partial class ScriptReferenceCollection : System.Collections.ObjectModel.Collection<System.Web.UI.ScriptReference> {
    public ScriptReferenceCollection() { }
  }
  public partial class ScriptReferenceEventArgs : System.EventArgs {
    public ScriptReferenceEventArgs(System.Web.UI.ScriptReference script) { }
    public System.Web.UI.ScriptReference Script { get { return default(System.Web.UI.ScriptReference); } }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(1), AllowMultiple=true)]
  public sealed partial class ScriptResourceAttribute : System.Attribute {
    public ScriptResourceAttribute(string scriptName) { }
    public ScriptResourceAttribute(string scriptName, string stringResourceName, string stringResourceClientTypeName) { }
    public string ScriptName { get { return default(string); } }
    [System.ObsoleteAttribute("This property is obsolete. Use StringResourceName instead.")]
    public string ScriptResourceName { get { return default(string); } }
    public string StringResourceClientTypeName { get { return default(string); } }
    public string StringResourceName { get { return default(string); } }
    [System.ObsoleteAttribute("This property is obsolete. Use StringResourceClientTypeName instead.")]
    public string TypeName { get { return default(string); } }
  }
  public partial class ScriptResourceDefinition {
    public ScriptResourceDefinition() { }
    public string CdnDebugPath { get { return default(string); } set { } }
    public string CdnPath { get { return default(string); } set { } }
    public bool CdnSupportsSecureConnection { get { return default(bool); } set { } }
    public string DebugPath { get { return default(string); } set { } }
    public string LoadSuccessExpression { get { return default(string); } set { } }
    public string Path { get { return default(string); } set { } }
    public System.Reflection.Assembly ResourceAssembly { get { return default(System.Reflection.Assembly); } set { } }
    public string ResourceName { get { return default(string); } set { } }
  }
  public partial class ScriptResourceMapping {
    public ScriptResourceMapping() { }
    public void AddDefinition(string name, System.Reflection.Assembly assembly, System.Web.UI.ScriptResourceDefinition definition) { }
    public void AddDefinition(string name, System.Web.UI.ScriptResourceDefinition definition) { }
    public void Clear() { }
    public System.Web.UI.ScriptResourceDefinition GetDefinition(string name) { return default(System.Web.UI.ScriptResourceDefinition); }
    public System.Web.UI.ScriptResourceDefinition GetDefinition(string name, System.Reflection.Assembly assembly) { return default(System.Web.UI.ScriptResourceDefinition); }
    public System.Web.UI.ScriptResourceDefinition GetDefinition(System.Web.UI.ScriptReference scriptReference) { return default(System.Web.UI.ScriptResourceDefinition); }
    public System.Web.UI.ScriptResourceDefinition RemoveDefinition(string name) { return default(System.Web.UI.ScriptResourceDefinition); }
    public System.Web.UI.ScriptResourceDefinition RemoveDefinition(string name, System.Reflection.Assembly assembly) { return default(System.Web.UI.ScriptResourceDefinition); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Path")]
  public partial class ServiceReference {
    public ServiceReference() { }
    public ServiceReference(string path) { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("ServiceReference_InlineScript")]
    public virtual bool InlineScript { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("ServiceReference_Path")]
    [System.Web.UI.UrlPropertyAttribute]
    public virtual string Path { get { return default(string); } set { } }
    protected internal virtual string GetProxyScript(System.Web.UI.ScriptManager scriptManager, System.Web.UI.Control containingControl) { return default(string); }
    protected internal virtual string GetProxyUrl(System.Web.UI.ScriptManager scriptManager, System.Web.UI.Control containingControl) { return default(string); }
    public override string ToString() { return default(string); }
  }
  public partial class ServiceReferenceCollection : System.Collections.ObjectModel.Collection<System.Web.UI.ServiceReference> {
    public ServiceReferenceCollection() { }
  }
  [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true)]
  public sealed partial class TargetControlTypeAttribute : System.Attribute {
    public TargetControlTypeAttribute(System.Type targetControlType) { }
    public System.Type TargetControlType { get { return default(System.Type); } }
    public override object TypeId { get { return default(object); } }
  }
  [System.ComponentModel.DefaultEventAttribute("Tick")]
  [System.ComponentModel.DefaultPropertyAttribute("Interval")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.TimerDesigner, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(EmbeddedResourceFinder), "System.Web.Resources.Timer.bmp")]
  [System.Web.UI.NonVisualControlAttribute]
  [System.Web.UI.SupportsEventValidationAttribute]
  public partial class Timer : System.Web.UI.Control, System.Web.UI.IPostBackEventHandler, System.Web.UI.IScriptControl {
    public Timer() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("Timer_TimerEnable")]
    public bool Enabled { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(60000)]
    [System.Web.UI.ResourceDescriptionAttribute("Timer_TimerInterval")]
    public int Interval { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override bool Visible { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("Timer_TimerTick")]
    public event System.EventHandler<System.EventArgs> Tick { add { } remove { } }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Web.UI.Timer.<GetScriptDescriptors>d__22))]
    protected virtual System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Web.UI.Timer.<GetScriptReferences>d__23))]
    protected virtual System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference>); }
    protected internal override void OnPreRender(System.EventArgs e) { }
    protected virtual void OnTick(System.EventArgs e) { }
    protected virtual void RaisePostBackEvent(string eventArgument) { }
    protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
    void System.Web.UI.IPostBackEventHandler.RaisePostBackEvent(string eventArgument) { }
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> System.Web.UI.IScriptControl.GetScriptDescriptors() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor>); }
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> System.Web.UI.IScriptControl.GetScriptReferences() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference>); }
  }
  [System.ComponentModel.DefaultPropertyAttribute("Triggers")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.UpdatePanelDesigner, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(EmbeddedResourceFinder), "System.Web.Resources.UpdatePanel.bmp")]
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public partial class UpdatePanel : System.Web.UI.Control, System.Web.UI.IAttributeAccessor {
    public UpdatePanel() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.WebSysDescriptionAttribute("WebControl_Attributes")]
    public System.Web.UI.AttributeCollection Attributes { get { return default(System.Web.UI.AttributeCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("UpdatePanel_ChildrenAsTriggers")]
    public bool ChildrenAsTriggers { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.TemplateInstanceAttribute((System.Web.UI.TemplateInstance)(1))]
    public System.Web.UI.ITemplate ContentTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.UI.Control ContentTemplateContainer { get { return default(System.Web.UI.Control); } }
    public sealed override System.Web.UI.ControlCollection Controls { get { return default(System.Web.UI.ControlCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public bool IsInPartialRendering { get { return default(bool); } }
    [System.ComponentModel.CategoryAttribute("Layout")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.UpdatePanelRenderMode)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("UpdatePanel_RenderMode")]
    public System.Web.UI.UpdatePanelRenderMode RenderMode { get { return default(System.Web.UI.UpdatePanelRenderMode); } set { } }
    protected internal virtual bool RequiresUpdate { get { return default(bool); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.UpdatePanelTriggerCollectionEditor, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("UpdatePanel_Triggers")]
    public System.Web.UI.UpdatePanelTriggerCollection Triggers { get { return default(System.Web.UI.UpdatePanelTriggerCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.UpdatePanelUpdateMode)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("UpdatePanel_UpdateMode")]
    public System.Web.UI.UpdatePanelUpdateMode UpdateMode { get { return default(System.Web.UI.UpdatePanelUpdateMode); } set { } }
    protected virtual System.Web.UI.Control CreateContentTemplateContainer() { return default(System.Web.UI.Control); }
    protected sealed override System.Web.UI.ControlCollection CreateControlCollection() { return default(System.Web.UI.ControlCollection); }
    protected internal virtual void Initialize() { }
    protected internal override void OnInit(System.EventArgs e) { }
    protected internal override void OnLoad(System.EventArgs e) { }
    protected internal override void OnPreRender(System.EventArgs e) { }
    protected internal override void OnUnload(System.EventArgs e) { }
    protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
    protected internal override void RenderChildren(System.Web.UI.HtmlTextWriter writer) { }
    string System.Web.UI.IAttributeAccessor.GetAttribute(string key) { return default(string); }
    void System.Web.UI.IAttributeAccessor.SetAttribute(string key, string value) { }
    public void Update() { }
  }
  public abstract partial class UpdatePanelControlTrigger : System.Web.UI.UpdatePanelTrigger {
    protected UpdatePanelControlTrigger() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.IDReferencePropertyAttribute]
    [System.Web.UI.ResourceDescriptionAttribute("UpdatePanelControlTrigger_ControlID")]
    public string ControlID { get { return default(string); } set { } }
    protected System.Web.UI.Control FindTargetControl(bool searchNamingContainers) { return default(System.Web.UI.Control); }
  }
  public enum UpdatePanelRenderMode {
    Block = 0,
    Inline = 1,
  }
  public abstract partial class UpdatePanelTrigger {
    protected UpdatePanelTrigger() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.UI.UpdatePanel Owner { get { return default(System.Web.UI.UpdatePanel); } }
    protected internal abstract bool HasTriggered();
    protected internal virtual void Initialize() { }
  }
  public partial class UpdatePanelTriggerCollection : System.Collections.ObjectModel.Collection<System.Web.UI.UpdatePanelTrigger> {
    public UpdatePanelTriggerCollection(System.Web.UI.UpdatePanel owner) { }
    public System.Web.UI.UpdatePanel Owner { get { return default(System.Web.UI.UpdatePanel); } }
    protected override void ClearItems() { }
    protected override void InsertItem(int index, System.Web.UI.UpdatePanelTrigger item) { }
    protected override void RemoveItem(int index) { }
    protected override void SetItem(int index, System.Web.UI.UpdatePanelTrigger item) { }
  }
  public enum UpdatePanelUpdateMode {
    Always = 0,
    Conditional = 1,
  }
  [System.ComponentModel.DefaultPropertyAttribute("AssociatedUpdatePanelID")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.UpdateProgressDesigner, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(EmbeddedResourceFinder), "System.Web.Resources.UpdateProgress.bmp")]
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public partial class UpdateProgress : System.Web.UI.Control, System.Web.UI.IAttributeAccessor, System.Web.UI.IScriptControl {
    public UpdateProgress() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.UpdateProgressAssociatedUpdatePanelIDConverter")]
    [System.Web.UI.IDReferencePropertyAttribute(typeof(System.Web.UI.UpdatePanel))]
    [System.Web.UI.ResourceDescriptionAttribute("UpdateProgress_AssociatedUpdatePanelID")]
    public string AssociatedUpdatePanelID { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.WebSysDescriptionAttribute("WebControl_Attributes")]
    public System.Web.UI.AttributeCollection Attributes { get { return default(System.Web.UI.AttributeCollection); } }
    public override System.Web.UI.ControlCollection Controls { get { return default(System.Web.UI.ControlCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(500)]
    [System.Web.UI.ResourceDescriptionAttribute("UpdateProgress_DisplayAfter")]
    public int DisplayAfter { get { return default(int); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("UpdateProgress_DynamicLayout")]
    public bool DynamicLayout { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("UpdateProgress_ProgressTemplate")]
    public System.Web.UI.ITemplate ProgressTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    protected internal override void CreateChildControls() { }
    public override void DataBind() { }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Web.UI.UpdateProgress.<GetScriptDescriptors>d__29))]
    protected virtual System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> GetScriptDescriptors() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor>); }
    [System.Runtime.CompilerServices.IteratorStateMachineAttribute(typeof(System.Web.UI.UpdateProgress.<GetScriptReferences>d__28))]
    protected virtual System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> GetScriptReferences() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference>); }
    protected internal override void OnPreRender(System.EventArgs e) { }
    protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
    string System.Web.UI.IAttributeAccessor.GetAttribute(string key) { return default(string); }
    void System.Web.UI.IAttributeAccessor.SetAttribute(string key, string value) { }
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor> System.Web.UI.IScriptControl.GetScriptDescriptors() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptDescriptor>); }
    System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference> System.Web.UI.IScriptControl.GetScriptReferences() { return default(System.Collections.Generic.IEnumerable<System.Web.UI.ScriptReference>); }
  }
}
namespace System.Web.UI.WebControls {
  public abstract partial class ContextDataSource : System.Web.UI.WebControls.QueryableDataSource {
    protected ContextDataSource() { }
    public virtual string ContextTypeName { get { return default(string); } set { } }
    protected string EntitySetName { get { return default(string); } set { } }
    public virtual string EntityTypeName { get { return default(string); } set { } }
  }
  public partial class ContextDataSourceContextData {
    public ContextDataSourceContextData() { }
    public ContextDataSourceContextData(object context) { }
    public object Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public object EntitySet { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  public abstract partial class ContextDataSourceView : System.Web.UI.WebControls.QueryableDataSourceView {
    protected static readonly object EventContextCreated;
    protected static readonly object EventContextCreating;
    protected static readonly object EventContextDisposing;
    protected ContextDataSourceView(System.Web.UI.DataSourceControl owner, string viewName, System.Web.HttpContext context) : base (default(System.Web.UI.DataSourceControl), default(string), default(System.Web.HttpContext)) { }
    protected object Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual System.Type ContextType { get { return default(System.Type); } }
    public virtual string ContextTypeName { get { return default(string); } set { } }
    protected object EntitySet { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } }
    public string EntitySetName { get { return default(string); } set { } }
    protected System.Type EntitySetType { get { return default(System.Type); } }
    protected override System.Type EntityType { get { return default(System.Type); } }
    public string EntityTypeName { get { return default(string); } set { } }
    protected virtual System.Web.UI.WebControls.ContextDataSourceContextData CreateContext(System.Web.UI.DataSourceOperation operation) { return default(System.Web.UI.WebControls.ContextDataSourceContextData); }
    protected void DisposeContext() { }
    protected virtual void DisposeContext(object dataContext) { }
    protected override int ExecuteDelete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { return default(int); }
    protected override int ExecuteInsert(System.Collections.IDictionary values) { return default(int); }
    protected override int ExecuteUpdate(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { return default(int); }
    protected virtual System.Type GetDataObjectType(System.Type type) { return default(System.Type); }
    protected virtual System.Type GetEntitySetType() { return default(System.Type); }
    protected override object GetSource(System.Web.UI.WebControls.QueryContext context) { return default(object); }
  }
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.WebControls.DataPagerDesigner, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.UI.WebControls.DataPager), "DataPager.bmp")]
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  [System.Web.UI.SupportsEventValidationAttribute]
  [System.Web.UI.ThemeableAttribute(true)]
  public partial class DataPager : System.Web.UI.Control, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, System.Web.UI.WebControls.ICompositeControlDesignerAccessor {
    public DataPager() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.AttributeCollection Attributes { get { return default(System.Web.UI.AttributeCollection); } }
    public override System.Web.UI.ControlCollection Controls { get { return default(System.Web.UI.ControlCollection); } }
    [System.ComponentModel.CategoryAttribute("Default")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.WebControls.DataPagerFieldTypeEditor, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("DataPager_Fields")]
    public virtual System.Web.UI.WebControls.DataPagerFieldCollection Fields { get { return default(System.Web.UI.WebControls.DataPagerFieldCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int MaximumRows { get { return default(int); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.IDReferencePropertyAttribute(typeof(System.Web.UI.WebControls.IPageableItemContainer))]
    [System.Web.UI.ResourceDescriptionAttribute("DataPager_PagedControlID")]
    [System.Web.UI.ThemeableAttribute(false)]
    [System.Web.WebCategoryAttribute("Paging")]
    public virtual string PagedControlID { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute(10)]
    [System.Web.UI.ResourceDescriptionAttribute("DataPager_PageSize")]
    [System.Web.WebCategoryAttribute("Paging")]
    public int PageSize { get { return default(int); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("DataPager_QueryStringField")]
    [System.Web.WebCategoryAttribute("Paging")]
    public string QueryStringField { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int StartRowIndex { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    protected virtual System.Web.UI.HtmlTextWriterTag TagKey { get { return default(System.Web.UI.HtmlTextWriterTag); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public int TotalRowCount { get { return default(int); } }
    protected virtual void AddAttributesToRender(System.Web.UI.HtmlTextWriter writer) { }
    protected virtual void ConnectToEvents(System.Web.UI.WebControls.IPageableItemContainer container) { }
    protected virtual void CreatePagerFields() { }
    public override void DataBind() { }
    protected virtual System.Web.UI.WebControls.IPageableItemContainer FindPageableItemContainer() { return default(System.Web.UI.WebControls.IPageableItemContainer); }
    protected internal override void LoadControlState(object savedState) { }
    protected override void LoadViewState(object savedState) { }
    protected override bool OnBubbleEvent(object source, System.EventArgs e) { return default(bool); }
    protected internal override void OnInit(System.EventArgs e) { }
    protected internal override void OnLoad(System.EventArgs e) { }
    protected virtual void OnTotalRowCountAvailable(object sender, System.Web.UI.WebControls.PageEventArgs e) { }
    protected virtual void RecreateChildControls() { }
    protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
    public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriter writer) { }
    protected virtual void RenderContents(System.Web.UI.HtmlTextWriter writer) { }
    protected internal override object SaveControlState() { return default(object); }
    protected override object SaveViewState() { return default(object); }
    public virtual void SetPageProperties(int startRowIndex, int maximumRows, bool databind) { }
    string System.Web.UI.IAttributeAccessor.GetAttribute(string name) { return default(string); }
    void System.Web.UI.IAttributeAccessor.SetAttribute(string name, string value) { }
    void System.Web.UI.WebControls.ICompositeControlDesignerAccessor.RecreateChildControls() { }
    protected override void TrackViewState() { }
  }
  public partial class DataPagerCommandEventArgs : System.Web.UI.WebControls.CommandEventArgs {
    public DataPagerCommandEventArgs(System.Web.UI.WebControls.DataPagerField pagerField, int totalRowCount, System.Web.UI.WebControls.CommandEventArgs originalArgs, System.Web.UI.WebControls.DataPagerFieldItem item) : base (default(System.Web.UI.WebControls.CommandEventArgs)) { }
    public System.Web.UI.WebControls.DataPagerFieldItem Item { get { return default(System.Web.UI.WebControls.DataPagerFieldItem); } }
    public int NewMaximumRows { get { return default(int); } set { } }
    public int NewStartRowIndex { get { return default(int); } set { } }
    public System.Web.UI.WebControls.DataPagerField PagerField { get { return default(System.Web.UI.WebControls.DataPagerField); } }
    public int TotalRowCount { get { return default(int); } }
  }
  public abstract partial class DataPagerField : System.Web.UI.IStateManager {
    protected DataPagerField() { }
    protected System.Web.UI.WebControls.DataPager DataPager { get { return default(System.Web.UI.WebControls.DataPager); } }
    protected bool IsTrackingViewState { get { return default(bool); } }
    protected bool QueryStringHandled { get { return default(bool); } set { } }
    protected string QueryStringValue { get { return default(string); } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    protected System.Web.UI.StateBag ViewState { get { return default(System.Web.UI.StateBag); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("DataPagerField_Visible")]
    public bool Visible { get { return default(bool); } set { } }
    protected internal System.Web.UI.WebControls.DataPagerField CloneField() { return default(System.Web.UI.WebControls.DataPagerField); }
    protected virtual void CopyProperties(System.Web.UI.WebControls.DataPagerField newField) { }
    public abstract void CreateDataPagers(System.Web.UI.WebControls.DataPagerFieldItem container, int startRowIndex, int maximumRows, int totalRowCount, int fieldIndex);
    protected abstract System.Web.UI.WebControls.DataPagerField CreateField();
    protected string GetQueryStringNavigateUrl(int pageNumber) { return default(string); }
    public abstract void HandleEvent(System.Web.UI.WebControls.CommandEventArgs e);
    protected virtual void LoadViewState(object savedState) { }
    protected virtual void OnFieldChanged() { }
    protected virtual object SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.LoadViewState(object state) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
    protected virtual void TrackViewState() { }
  }
  public partial class DataPagerFieldCollection : System.Web.UI.StateManagedCollection {
    public DataPagerFieldCollection(System.Web.UI.WebControls.DataPager dataPager) { }
    [System.ComponentModel.BrowsableAttribute(false)]
    public System.Web.UI.WebControls.DataPagerField this[int index] { get { return default(System.Web.UI.WebControls.DataPagerField); } }
    public event System.EventHandler FieldsChanged { add { } remove { } }
    public void Add(System.Web.UI.WebControls.DataPagerField field) { }
    public System.Web.UI.WebControls.DataPagerFieldCollection CloneFields(System.Web.UI.WebControls.DataPager pager) { return default(System.Web.UI.WebControls.DataPagerFieldCollection); }
    public bool Contains(System.Web.UI.WebControls.DataPagerField field) { return default(bool); }
    public void CopyTo(System.Web.UI.WebControls.DataPagerField[] array, int index) { }
    protected override object CreateKnownType(int index) { return default(object); }
    protected override System.Type[] GetKnownTypes() { return default(System.Type[]); }
    public int IndexOf(System.Web.UI.WebControls.DataPagerField field) { return default(int); }
    public void Insert(int index, System.Web.UI.WebControls.DataPagerField field) { }
    protected override void OnClearComplete() { }
    protected override void OnInsertComplete(int index, object value) { }
    protected override void OnRemoveComplete(int index, object value) { }
    protected override void OnValidate(object o) { }
    public void Remove(System.Web.UI.WebControls.DataPagerField field) { }
    public void RemoveAt(int index) { }
    protected override void SetDirtyObject(object o) { }
  }
  public partial class DataPagerFieldCommandEventArgs : System.Web.UI.WebControls.CommandEventArgs {
    public DataPagerFieldCommandEventArgs(System.Web.UI.WebControls.DataPagerFieldItem item, object commandSource, System.Web.UI.WebControls.CommandEventArgs originalArgs) : base (default(System.Web.UI.WebControls.CommandEventArgs)) { }
    public object CommandSource { get { return default(object); } }
    public System.Web.UI.WebControls.DataPagerFieldItem Item { get { return default(System.Web.UI.WebControls.DataPagerFieldItem); } }
  }
  public partial class DataPagerFieldItem : System.Web.UI.Control, System.Web.UI.INamingContainer {
    public DataPagerFieldItem(System.Web.UI.WebControls.DataPagerField field, System.Web.UI.WebControls.DataPager pager) { }
    public System.Web.UI.WebControls.DataPager Pager { get { return default(System.Web.UI.WebControls.DataPager); } }
    public System.Web.UI.WebControls.DataPagerField PagerField { get { return default(System.Web.UI.WebControls.DataPagerField); } }
    protected override bool OnBubbleEvent(object source, System.EventArgs e) { return default(bool); }
  }
  public enum InsertItemPosition {
    FirstItem = 1,
    LastItem = 2,
    None = 0,
  }
  public partial interface IPageableItemContainer {
    int MaximumRows { get; }
    int StartRowIndex { get; }
    event System.EventHandler<System.Web.UI.WebControls.PageEventArgs> TotalRowCountAvailable;
    void SetPageProperties(int startRowIndex, int maximumRows, bool databind);
  }
  public partial interface IQueryableDataSource : System.Web.UI.IDataSource {
    event System.EventHandler<System.Web.UI.WebControls.QueryCreatedEventArgs> QueryCreated;
    void RaiseViewChanged();
  }
  [System.ComponentModel.DefaultEventAttribute("Selecting")]
  [System.ComponentModel.DefaultPropertyAttribute("ContextTypeName")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.WebControls.LinqDataSourceDesigner, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.UI.WebControls.LinqDataSource), "LinqDataSource.bmp")]
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Description")]
  [System.Web.UI.ResourceDisplayNameAttribute("LinqDataSource_DisplayName")]
  public partial class LinqDataSource : System.Web.UI.WebControls.ContextDataSource, System.Web.DynamicData.IDynamicDataSource, System.Web.UI.IDataSource {
    public LinqDataSource() { }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_AutoGenerateOrderByClause")]
    public bool AutoGenerateOrderByClause { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_AutoGenerateWhereClause")]
    public bool AutoGenerateWhereClause { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_AutoPage")]
    public bool AutoPage { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_AutoSort")]
    public bool AutoSort { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_ContextTypeName")]
    public override string ContextTypeName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_DeleteParameters")]
    public System.Web.UI.WebControls.ParameterCollection DeleteParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_EnableDelete")]
    public bool EnableDelete { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_EnableInsert")]
    public bool EnableInsert { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_EnableObjectTracking")]
    public bool EnableObjectTracking { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_EnableUpdate")]
    public bool EnableUpdate { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_GroupBy")]
    public string GroupBy { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_GroupByParameters")]
    public System.Web.UI.WebControls.ParameterCollection GroupByParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_InsertParameters")]
    public System.Web.UI.WebControls.ParameterCollection InsertParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_OrderBy")]
    public string OrderBy { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_OrderByParameters")]
    public System.Web.UI.WebControls.ParameterCollection OrderByParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_OrderGroupsBy")]
    public string OrderGroupsBy { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_OrderGroupsByParameters")]
    public System.Web.UI.WebControls.ParameterCollection OrderGroupsByParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Select")]
    public string Select { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_SelectParameters")]
    public System.Web.UI.WebControls.ParameterCollection SelectParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_StoreOriginalValuesInViewState")]
    public bool StoreOriginalValuesInViewState { get { return default(bool); } set { } }
    System.Type System.Web.DynamicData.IDynamicDataSource.ContextType { get { return default(System.Type); } set { } }
    string System.Web.DynamicData.IDynamicDataSource.EntitySetName { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_TableName")]
    public string TableName { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_UpdateParameters")]
    public System.Web.UI.WebControls.ParameterCollection UpdateParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Where")]
    public string Where { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.MergablePropertyAttribute(false)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_WhereParameters")]
    public System.Web.UI.WebControls.ParameterCollection WhereParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_ContextCreated")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> ContextCreated { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_ContextCreating")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceContextEventArgs> ContextCreating { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_ContextDisposing")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceDisposeEventArgs> ContextDisposing { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Deleted")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Deleted { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Deleting")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceDeleteEventArgs> Deleting { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Inserted")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Inserted { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Inserting")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceInsertEventArgs> Inserting { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Selected")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Selected { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Selecting")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceSelectEventArgs> Selecting { add { } remove { } }
    event System.EventHandler<System.Web.DynamicData.DynamicValidatorEventArgs> System.Web.DynamicData.IDynamicDataSource.Exception { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Updated")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Updated { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("LinqDataSource_Updating")]
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceUpdateEventArgs> Updating { add { } remove { } }
    protected override System.Web.UI.WebControls.QueryableDataSourceView CreateQueryableView() { return default(System.Web.UI.WebControls.QueryableDataSourceView); }
    protected virtual System.Web.UI.WebControls.LinqDataSourceView CreateView() { return default(System.Web.UI.WebControls.LinqDataSourceView); }
    public int Delete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { return default(int); }
    public int Insert(System.Collections.IDictionary values) { return default(int); }
    protected internal override void OnInit(System.EventArgs e) { }
    protected internal override void OnUnload(System.EventArgs e) { }
    public int Update(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { return default(int); }
  }
  public partial class LinqDataSourceContextEventArgs : System.EventArgs {
    public LinqDataSourceContextEventArgs() { }
    public LinqDataSourceContextEventArgs(System.Web.UI.DataSourceOperation operation) { }
    public object ObjectInstance { get { return default(object); } set { } }
    public System.Web.UI.DataSourceOperation Operation { get { return default(System.Web.UI.DataSourceOperation); } }
  }
  public partial class LinqDataSourceDeleteEventArgs : System.ComponentModel.CancelEventArgs {
    public LinqDataSourceDeleteEventArgs(object originalObject) { }
    public LinqDataSourceDeleteEventArgs(System.Web.UI.WebControls.LinqDataSourceValidationException exception) { }
    public System.Web.UI.WebControls.LinqDataSourceValidationException Exception { get { return default(System.Web.UI.WebControls.LinqDataSourceValidationException); } }
    public bool ExceptionHandled { get { return default(bool); } set { } }
    public object OriginalObject { get { return default(object); } }
  }
  public partial class LinqDataSourceDisposeEventArgs : System.ComponentModel.CancelEventArgs {
    public LinqDataSourceDisposeEventArgs(object instance) { }
    public object ObjectInstance { get { return default(object); } }
  }
  public partial class LinqDataSourceInsertEventArgs : System.ComponentModel.CancelEventArgs {
    public LinqDataSourceInsertEventArgs(object newObject) { }
    public LinqDataSourceInsertEventArgs(System.Web.UI.WebControls.LinqDataSourceValidationException exception) { }
    public System.Web.UI.WebControls.LinqDataSourceValidationException Exception { get { return default(System.Web.UI.WebControls.LinqDataSourceValidationException); } }
    public bool ExceptionHandled { get { return default(bool); } set { } }
    public object NewObject { get { return default(object); } }
  }
  public partial class LinqDataSourceSelectEventArgs : System.ComponentModel.CancelEventArgs {
    public LinqDataSourceSelectEventArgs(System.Web.UI.DataSourceSelectArguments arguments, System.Collections.Generic.IDictionary<System.String, System.Object> whereParameters, System.Collections.Specialized.IOrderedDictionary orderByParameters, System.Collections.Generic.IDictionary<System.String, System.Object> groupByParameters, System.Collections.Generic.IDictionary<System.String, System.Object> orderGroupsByParameters, System.Collections.Generic.IDictionary<System.String, System.Object> selectParameters) { }
    public System.Web.UI.DataSourceSelectArguments Arguments { get { return default(System.Web.UI.DataSourceSelectArguments); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> GroupByParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public System.Collections.Specialized.IOrderedDictionary OrderByParameters { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> OrderGroupsByParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public object Result { get { return default(object); } set { } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> SelectParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> WhereParameters { get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
  }
  public partial class LinqDataSourceStatusEventArgs : System.EventArgs {
    public LinqDataSourceStatusEventArgs(System.Exception exception) { }
    public LinqDataSourceStatusEventArgs(object result) { }
    public LinqDataSourceStatusEventArgs(object result, int totalRowCount) { }
    public System.Exception Exception { get { return default(System.Exception); } }
    public bool ExceptionHandled { get { return default(bool); } set { } }
    public object Result { get { return default(object); } }
    public int TotalRowCount { get { return default(int); } }
  }
  public partial class LinqDataSourceUpdateEventArgs : System.ComponentModel.CancelEventArgs {
    public LinqDataSourceUpdateEventArgs(object originalObject, object newObject) { }
    public LinqDataSourceUpdateEventArgs(System.Web.UI.WebControls.LinqDataSourceValidationException exception) { }
    public System.Web.UI.WebControls.LinqDataSourceValidationException Exception { get { return default(System.Web.UI.WebControls.LinqDataSourceValidationException); } }
    public bool ExceptionHandled { get { return default(bool); } set { } }
    public object NewObject { get { return default(object); } }
    public object OriginalObject { get { return default(object); } }
  }
  public partial class LinqDataSourceValidationException : System.Exception, System.Runtime.Serialization.ISerializable, System.Web.DynamicData.IDynamicValidatorException {
    public LinqDataSourceValidationException() { }
    protected LinqDataSourceValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    public LinqDataSourceValidationException(string message) { }
    public LinqDataSourceValidationException(string message, System.Collections.Generic.IDictionary<System.String, System.Exception> innerExceptions) { }
    public LinqDataSourceValidationException(string message, System.Exception innerException) { }
    public System.Collections.Generic.IDictionary<System.String, System.Exception> InnerExceptions { get { return default(System.Collections.Generic.IDictionary<System.String, System.Exception>); } }
    [System.Security.SecurityCriticalAttribute]
    public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
  }
  public partial class LinqDataSourceView : System.Web.UI.WebControls.ContextDataSourceView {
    public LinqDataSourceView(System.Web.UI.WebControls.LinqDataSource owner, string name, System.Web.HttpContext context) : base (default(System.Web.UI.DataSourceControl), default(string), default(System.Web.HttpContext)) { }
    public override bool CanDelete { get { return default(bool); } }
    public override bool CanInsert { get { return default(bool); } }
    public override bool CanPage { get { return default(bool); } }
    public override bool CanRetrieveTotalRowCount { get { return default(bool); } }
    public override bool CanSort { get { return default(bool); } }
    public override bool CanUpdate { get { return default(bool); } }
    public override System.Type ContextType { [System.Security.SecuritySafeCriticalAttribute]get { return default(System.Type); } }
    public override string ContextTypeName { get { return default(string); } set { } }
    public bool EnableDelete { get { return default(bool); } set { } }
    public bool EnableInsert { get { return default(bool); } set { } }
    public bool EnableObjectTracking { get { return default(bool); } set { } }
    public bool EnableUpdate { get { return default(bool); } set { } }
    public bool StoreOriginalValuesInViewState { get { return default(bool); } set { } }
    public string TableName { get { return default(string); } set { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> ContextCreated { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceContextEventArgs> ContextCreating { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceDisposeEventArgs> ContextDisposing { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Deleted { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceDeleteEventArgs> Deleting { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Inserted { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceInsertEventArgs> Inserting { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Selected { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceSelectEventArgs> Selecting { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceStatusEventArgs> Updated { add { } remove { } }
    public event System.EventHandler<System.Web.UI.WebControls.LinqDataSourceUpdateEventArgs> Updating { add { } remove { } }
    protected virtual object CreateContext(System.Type contextType) { return default(object); }
    protected override System.Web.UI.WebControls.ContextDataSourceContextData CreateContext(System.Web.UI.DataSourceOperation operation) { return default(System.Web.UI.WebControls.ContextDataSourceContextData); }
    protected virtual void DeleteDataObject(object dataContext, object table, object oldDataObject) { }
    protected override int DeleteObject(object oldEntity) { return default(int); }
    protected override void DisposeContext(object dataContext) { }
    protected override int ExecuteDelete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { return default(int); }
    protected override int ExecuteInsert(System.Collections.IDictionary values) { return default(int); }
    protected internal override System.Collections.IEnumerable ExecuteSelect(System.Web.UI.DataSourceSelectArguments arguments) { return default(System.Collections.IEnumerable); }
    protected override int ExecuteUpdate(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { return default(int); }
    protected override object GetSource(System.Web.UI.WebControls.QueryContext context) { return default(object); }
    protected virtual System.Reflection.MemberInfo GetTableMemberInfo(System.Type contextType) { return default(System.Reflection.MemberInfo); }
    protected override void HandleValidationErrors(System.Collections.Generic.IDictionary<System.String, System.Exception> errors, System.Web.UI.DataSourceOperation operation) { }
    protected virtual void InsertDataObject(object dataContext, object table, object newDataObject) { }
    protected override int InsertObject(object newEntity) { return default(int); }
    protected virtual void OnContextCreated(System.Web.UI.WebControls.LinqDataSourceStatusEventArgs e) { }
    protected virtual void OnContextCreating(System.Web.UI.WebControls.LinqDataSourceContextEventArgs e) { }
    protected virtual void OnContextDisposing(System.Web.UI.WebControls.LinqDataSourceDisposeEventArgs e) { }
    protected virtual void OnDeleted(System.Web.UI.WebControls.LinqDataSourceStatusEventArgs e) { }
    protected virtual void OnDeleting(System.Web.UI.WebControls.LinqDataSourceDeleteEventArgs e) { }
    protected virtual void OnException(System.Web.DynamicData.DynamicValidatorEventArgs e) { }
    protected virtual void OnInserted(System.Web.UI.WebControls.LinqDataSourceStatusEventArgs e) { }
    protected virtual void OnInserting(System.Web.UI.WebControls.LinqDataSourceInsertEventArgs e) { }
    protected virtual void OnSelected(System.Web.UI.WebControls.LinqDataSourceStatusEventArgs e) { }
    protected virtual void OnSelecting(System.Web.UI.WebControls.LinqDataSourceSelectEventArgs e) { }
    protected virtual void OnUpdated(System.Web.UI.WebControls.LinqDataSourceStatusEventArgs e) { }
    protected virtual void OnUpdating(System.Web.UI.WebControls.LinqDataSourceUpdateEventArgs e) { }
    protected virtual void ResetDataObject(object table, object dataObject) { }
    public System.Collections.IEnumerable Select(System.Web.UI.DataSourceSelectArguments arguments) { return default(System.Collections.IEnumerable); }
    protected override void StoreOriginalValues(System.Collections.IList results) { }
    protected virtual void UpdateDataObject(object dataContext, object table, object oldDataObject, object newDataObject) { }
    protected override int UpdateObject(object oldEntity, object newEntity) { return default(int); }
    protected virtual void ValidateContextType(System.Type contextType, bool selecting) { }
    protected virtual void ValidateDeleteSupported(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { }
    protected virtual void ValidateEditSupported() { }
    protected virtual void ValidateInsertSupported(System.Collections.IDictionary values) { }
    protected virtual void ValidateTableType(System.Type tableType, bool selecting) { }
    protected virtual void ValidateUpdateSupported(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { }
  }
  [System.ComponentModel.DefaultEventAttribute("SelectedIndexChanged")]
  [System.ComponentModel.DefaultPropertyAttribute("SelectedValue")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.WebControls.ListViewDesigner, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.UI.WebControls.ListView), "ListView.bmp")]
  [System.Web.UI.ControlValuePropertyAttribute("SelectedValue")]
  [System.Web.UI.DataKeyPropertyAttribute("SelectedPersistedDataKey")]
  [System.Web.UI.SupportsEventValidationAttribute]
  public partial class ListView : System.Web.UI.WebControls.DataBoundControl, System.Web.UI.IDataKeysControl, System.Web.UI.INamingContainer, System.Web.UI.WebControls.IDataBoundControl, System.Web.UI.WebControls.IDataBoundListControl, System.Web.UI.WebControls.IPageableItemContainer, System.Web.UI.WebControls.IPersistedSelector {
    public ListView() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override string AccessKey { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_AlternatingItemTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewDataItem), (System.ComponentModel.BindingDirection)(1))]
    public virtual System.Web.UI.ITemplate AlternatingItemTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Drawing.Color BackColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Drawing.Color BorderColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.WebControls.BorderStyle BorderStyle { get { return default(System.Web.UI.WebControls.BorderStyle); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.WebControls.Unit BorderWidth { get { return default(System.Web.UI.WebControls.Unit); } set { } }
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.StringArrayConverter))]
    [System.Web.WebCategoryAttribute("Data")]
    public virtual System.String[] ClientIDRowSuffix { get { return default(System.String[]); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public System.Web.UI.WebControls.DataKeyArray ClientIDRowSuffixDataKeys { get { return default(System.Web.UI.WebControls.DataKeyArray); } }
    public override System.Web.UI.ControlCollection Controls { get { return default(System.Web.UI.ControlCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_ConvertEmptyStringToNull")]
    public virtual bool ConvertEmptyStringToNull { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    [System.Web.UI.CssClassPropertyAttribute]
    public override string CssClass { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.WebControls.DataFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    [System.ComponentModel.TypeConverterAttribute(typeof(System.Web.UI.WebControls.StringArrayConverter))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_DataKeyNames")]
    public virtual System.String[] DataKeyNames { get { return default(System.String[]); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_DataKeys")]
    public virtual System.Web.UI.WebControls.DataKeyArray DataKeys { get { return default(System.Web.UI.WebControls.DataKeyArray); } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ThemeableAttribute(false)]
    [System.Web.WebCategoryAttribute("Data")]
    [System.Web.WebSysDescriptionAttribute("DataBoundControl_DeleteMethod")]
    public virtual string DeleteMethod { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Default")]
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_EditIndex")]
    public virtual int EditIndex { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_EditItem")]
    public virtual System.Web.UI.WebControls.ListViewItem EditItem { get { return default(System.Web.UI.WebControls.ListViewItem); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_EditItemTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewDataItem), (System.ComponentModel.BindingDirection)(1))]
    public virtual System.Web.UI.ITemplate EditItemTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_EmptyDataTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListView))]
    public virtual System.Web.UI.ITemplate EmptyDataTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_EmptyItemTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewItem))]
    public virtual System.Web.UI.ITemplate EmptyItemTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_EnableModelValidation")]
    [System.Web.WebCategoryAttribute("Behavior")]
    public virtual bool EnableModelValidation { get { return default(bool); } set { } }
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_EnablePersistedSelection")]
    [System.Web.WebCategoryAttribute("Behavior")]
    public virtual bool EnablePersistedSelection { get { return default(bool); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.WebControls.FontInfo Font { get { return default(System.Web.UI.WebControls.FontInfo); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Drawing.Color ForeColor { get { return default(System.Drawing.Color); } set { } }
    [System.ComponentModel.CategoryAttribute("Default")]
    [System.ComponentModel.DefaultValueAttribute(1)]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_GroupItemCount")]
    public virtual int GroupItemCount { get { return default(int); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("groupPlaceholder")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_GroupPlaceholderID")]
    public virtual string GroupPlaceholderID { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_GroupSeparatorTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewItem))]
    public virtual System.Web.UI.ITemplate GroupSeparatorTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_GroupTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewItem))]
    public virtual System.Web.UI.ITemplate GroupTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.WebControls.Unit Height { get { return default(System.Web.UI.WebControls.Unit); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_InsertItem")]
    public virtual System.Web.UI.WebControls.ListViewItem InsertItem { get { return default(System.Web.UI.WebControls.ListViewItem); } }
    [System.ComponentModel.CategoryAttribute("Default")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.InsertItemPosition)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_InsertItemPosition")]
    public virtual System.Web.UI.WebControls.InsertItemPosition InsertItemPosition { get { return default(System.Web.UI.WebControls.InsertItemPosition); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_InsertItemTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewItem), (System.ComponentModel.BindingDirection)(1))]
    public virtual System.Web.UI.ITemplate InsertItemTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ThemeableAttribute(false)]
    [System.Web.WebCategoryAttribute("Data")]
    [System.Web.WebSysDescriptionAttribute("DataBoundControl_InsertMethod")]
    public virtual string InsertMethod { get { return default(string); } set { } }
    protected override bool IsUsingModelBinders { get { return default(bool); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("itemPlaceholder")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_ItemPlaceholderID")]
    public virtual string ItemPlaceholderID { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_Items")]
    public virtual System.Collections.Generic.IList<System.Web.UI.WebControls.ListViewDataItem> Items { get { return default(System.Collections.Generic.IList<System.Web.UI.WebControls.ListViewDataItem>); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_ItemSeparatorTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewItem))]
    public virtual System.Web.UI.ITemplate ItemSeparatorTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_ItemTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewDataItem), (System.ComponentModel.BindingDirection)(1))]
    public virtual System.Web.UI.ITemplate ItemTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_LayoutTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListView))]
    public virtual System.Web.UI.ITemplate LayoutTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    protected virtual int MaximumRows { get { return default(int); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Web.UI.WebControls.DataKey SelectedDataKey { get { return default(System.Web.UI.WebControls.DataKey); } }
    [System.ComponentModel.CategoryAttribute("Default")]
    [System.ComponentModel.DefaultValueAttribute(-1)]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_SelectedIndex")]
    public virtual int SelectedIndex { get { return default(int); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_SelectedItemTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.ListViewDataItem), (System.ComponentModel.BindingDirection)(1))]
    public virtual System.Web.UI.ITemplate SelectedItemTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    public virtual System.Web.UI.WebControls.DataKey SelectedPersistedDataKey { get { return default(System.Web.UI.WebControls.DataKey); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public object SelectedValue { get { return default(object); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.SortDirection)(0))]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceCategoryAttribute("Sorting")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_SortDirection")]
    public virtual System.Web.UI.WebControls.SortDirection SortDirection { get { return default(System.Web.UI.WebControls.SortDirection); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.Web.UI.ResourceCategoryAttribute("Sorting")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_SortExpression")]
    public virtual string SortExpression { get { return default(string); } }
    protected virtual int StartRowIndex { get { return default(int); } }
    System.Web.UI.WebControls.DataKeyArray System.Web.UI.IDataKeysControl.ClientIDRowSuffixDataKeys { get { return default(System.Web.UI.WebControls.DataKeyArray); } }
    System.String[] System.Web.UI.WebControls.IDataBoundControl.DataKeyNames { get { return default(System.String[]); } set { } }
    string System.Web.UI.WebControls.IDataBoundControl.DataMember { get { return default(string); } set { } }
    object System.Web.UI.WebControls.IDataBoundControl.DataSource { get { return default(object); } set { } }
    string System.Web.UI.WebControls.IDataBoundControl.DataSourceID { get { return default(string); } set { } }
    System.Web.UI.IDataSource System.Web.UI.WebControls.IDataBoundControl.DataSourceObject { get { return default(System.Web.UI.IDataSource); } }
    System.String[] System.Web.UI.WebControls.IDataBoundListControl.ClientIDRowSuffix { get { return default(System.String[]); } set { } }
    System.Web.UI.WebControls.DataKeyArray System.Web.UI.WebControls.IDataBoundListControl.DataKeys { get { return default(System.Web.UI.WebControls.DataKeyArray); } }
    bool System.Web.UI.WebControls.IDataBoundListControl.EnablePersistedSelection { get { return default(bool); } set { } }
    System.Web.UI.WebControls.DataKey System.Web.UI.WebControls.IDataBoundListControl.SelectedDataKey { get { return default(System.Web.UI.WebControls.DataKey); } }
    int System.Web.UI.WebControls.IDataBoundListControl.SelectedIndex { get { return default(int); } set { } }
    int System.Web.UI.WebControls.IPageableItemContainer.MaximumRows { get { return default(int); } }
    int System.Web.UI.WebControls.IPageableItemContainer.StartRowIndex { get { return default(int); } }
    System.Web.UI.WebControls.DataKey System.Web.UI.WebControls.IPersistedSelector.DataKey { get { return default(System.Web.UI.WebControls.DataKey); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override short TabIndex { get { return default(short); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override string ToolTip { get { return default(string); } set { } }
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.ThemeableAttribute(false)]
    [System.Web.WebCategoryAttribute("Data")]
    [System.Web.WebSysDescriptionAttribute("DataBoundControl_UpdateMethod")]
    public virtual string UpdateMethod { get { return default(string); } set { } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public override System.Web.UI.WebControls.Unit Width { get { return default(System.Web.UI.WebControls.Unit); } set { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemCanceling")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewCancelEventArgs> ItemCanceling { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemCommand")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewCommandEventArgs> ItemCommand { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemCreated")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewItemEventArgs> ItemCreated { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Data")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemDataBound")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewItemEventArgs> ItemDataBound { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemDeleted")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewDeletedEventArgs> ItemDeleted { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemDeleting")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewDeleteEventArgs> ItemDeleting { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemEditing")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewEditEventArgs> ItemEditing { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemInserted")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewInsertedEventArgs> ItemInserted { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemInserting")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewInsertEventArgs> ItemInserting { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemUpdated")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewUpdatedEventArgs> ItemUpdated { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnItemUpdating")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewUpdateEventArgs> ItemUpdating { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnLayoutCreated")]
    public event System.EventHandler LayoutCreated { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnPagePropertiesChanged")]
    public event System.EventHandler PagePropertiesChanged { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnPagePropertiesChanging")]
    public event System.EventHandler<System.Web.UI.WebControls.PagePropertiesChangingEventArgs> PagePropertiesChanging { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnSelectedIndexChanged")]
    public event System.EventHandler SelectedIndexChanged { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnSelectedIndexChanging")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewSelectEventArgs> SelectedIndexChanging { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnSorted")]
    public event System.EventHandler Sorted { add { } remove { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("ListView_OnSorting")]
    public event System.EventHandler<System.Web.UI.WebControls.ListViewSortEventArgs> Sorting { add { } remove { } }
    event System.EventHandler<System.Web.UI.WebControls.PageEventArgs> System.Web.UI.WebControls.IPageableItemContainer.TotalRowCountAvailable { add { } remove { } }
    protected virtual void AddControlToContainer(System.Web.UI.Control control, System.Web.UI.Control container, int addLocation) { }
    protected internal override void CreateChildControls() { }
    protected virtual int CreateChildControls(System.Collections.IEnumerable dataSource, bool dataBinding) { return default(int); }
    protected override System.Web.UI.WebControls.Style CreateControlStyle() { return default(System.Web.UI.WebControls.Style); }
    protected virtual System.Web.UI.WebControls.ListViewDataItem CreateDataItem(int dataItemIndex, int displayIndex) { return default(System.Web.UI.WebControls.ListViewDataItem); }
    protected override System.Web.UI.DataSourceSelectArguments CreateDataSourceSelectArguments() { return default(System.Web.UI.DataSourceSelectArguments); }
    protected virtual void CreateEmptyDataItem() { }
    protected virtual System.Web.UI.WebControls.ListViewItem CreateEmptyItem() { return default(System.Web.UI.WebControls.ListViewItem); }
    protected virtual System.Web.UI.WebControls.ListViewItem CreateInsertItem() { return default(System.Web.UI.WebControls.ListViewItem); }
    protected virtual System.Web.UI.WebControls.ListViewItem CreateItem(System.Web.UI.WebControls.ListViewItemType itemType) { return default(System.Web.UI.WebControls.ListViewItem); }
    protected virtual System.Collections.Generic.IList<System.Web.UI.WebControls.ListViewDataItem> CreateItemsInGroups(System.Web.UI.WebControls.ListViewPagedDataSource dataSource, bool dataBinding, System.Web.UI.WebControls.InsertItemPosition insertPosition, System.Collections.ArrayList keyArray) { return default(System.Collections.Generic.IList<System.Web.UI.WebControls.ListViewDataItem>); }
    protected virtual System.Collections.Generic.IList<System.Web.UI.WebControls.ListViewDataItem> CreateItemsWithoutGroups(System.Web.UI.WebControls.ListViewPagedDataSource dataSource, bool dataBinding, System.Web.UI.WebControls.InsertItemPosition insertPosition, System.Collections.ArrayList keyArray) { return default(System.Collections.Generic.IList<System.Web.UI.WebControls.ListViewDataItem>); }
    protected virtual void CreateLayoutTemplate() { }
    protected virtual void CreateSuffixArrayList(System.Web.UI.WebControls.ListViewPagedDataSource dataSource, System.Collections.ArrayList suffixArray) { }
    public virtual void DeleteItem(int itemIndex) { }
    protected virtual void EnsureLayoutTemplate() { }
    public virtual void ExtractItemValues(System.Collections.Specialized.IOrderedDictionary itemValues, System.Web.UI.WebControls.ListViewItem item, bool includePrimaryKey) { }
    protected virtual System.Web.UI.Control FindPlaceholder(string containerID, System.Web.UI.Control container) { return default(System.Web.UI.Control); }
    public virtual void InsertNewItem(bool causesValidation) { }
    protected virtual void InstantiateEmptyDataTemplate(System.Web.UI.Control container) { }
    protected virtual void InstantiateEmptyItemTemplate(System.Web.UI.Control container) { }
    protected virtual void InstantiateGroupSeparatorTemplate(System.Web.UI.Control container) { }
    protected virtual void InstantiateGroupTemplate(System.Web.UI.Control container) { }
    protected virtual void InstantiateInsertItemTemplate(System.Web.UI.Control container) { }
    protected virtual void InstantiateItemSeparatorTemplate(System.Web.UI.Control container) { }
    protected virtual void InstantiateItemTemplate(System.Web.UI.Control container, int displayIndex) { }
    protected internal override void LoadControlState(object savedState) { }
    protected override void LoadViewState(object savedState) { }
    protected override bool OnBubbleEvent(object source, System.EventArgs e) { return default(bool); }
    protected internal override void OnInit(System.EventArgs e) { }
    protected virtual void OnItemCanceling(System.Web.UI.WebControls.ListViewCancelEventArgs e) { }
    protected virtual void OnItemCommand(System.Web.UI.WebControls.ListViewCommandEventArgs e) { }
    protected virtual void OnItemCreated(System.Web.UI.WebControls.ListViewItemEventArgs e) { }
    protected virtual void OnItemDataBound(System.Web.UI.WebControls.ListViewItemEventArgs e) { }
    protected virtual void OnItemDeleted(System.Web.UI.WebControls.ListViewDeletedEventArgs e) { }
    protected virtual void OnItemDeleting(System.Web.UI.WebControls.ListViewDeleteEventArgs e) { }
    protected virtual void OnItemEditing(System.Web.UI.WebControls.ListViewEditEventArgs e) { }
    protected virtual void OnItemInserted(System.Web.UI.WebControls.ListViewInsertedEventArgs e) { }
    protected virtual void OnItemInserting(System.Web.UI.WebControls.ListViewInsertEventArgs e) { }
    protected virtual void OnItemUpdated(System.Web.UI.WebControls.ListViewUpdatedEventArgs e) { }
    protected virtual void OnItemUpdating(System.Web.UI.WebControls.ListViewUpdateEventArgs e) { }
    protected virtual void OnLayoutCreated(System.EventArgs e) { }
    protected virtual void OnPagePropertiesChanged(System.EventArgs e) { }
    protected virtual void OnPagePropertiesChanging(System.Web.UI.WebControls.PagePropertiesChangingEventArgs e) { }
    protected virtual void OnSelectedIndexChanged(System.EventArgs e) { }
    protected virtual void OnSelectedIndexChanging(System.Web.UI.WebControls.ListViewSelectEventArgs e) { }
    protected virtual void OnSorted(System.EventArgs e) { }
    protected virtual void OnSorting(System.Web.UI.WebControls.ListViewSortEventArgs e) { }
    protected virtual void OnTotalRowCountAvailable(System.Web.UI.WebControls.PageEventArgs e) { }
    protected internal override void PerformDataBinding(System.Collections.IEnumerable data) { }
    protected override void PerformSelect() { }
    protected virtual void RemoveItems() { }
    protected internal override void Render(System.Web.UI.HtmlTextWriter writer) { }
    protected internal override object SaveControlState() { return default(object); }
    protected override object SaveViewState() { return default(object); }
    public void SelectItem(int rowIndex) { }
    public void SetEditItem(int rowIndex) { }
    protected virtual void SetPageProperties(int startRowIndex, int maximumRows, bool databind) { }
    public virtual void Sort(string sortExpression, System.Web.UI.WebControls.SortDirection sortDirection) { }
    void System.Web.UI.WebControls.IPageableItemContainer.SetPageProperties(int startRowIndex, int maximumRows, bool databind) { }
    public virtual void UpdateItem(int itemIndex, bool causesValidation) { }
  }
  public partial class ListViewCancelEventArgs : System.ComponentModel.CancelEventArgs {
    public ListViewCancelEventArgs(int itemIndex, System.Web.UI.WebControls.ListViewCancelMode cancelMode) { }
    public System.Web.UI.WebControls.ListViewCancelMode CancelMode { get { return default(System.Web.UI.WebControls.ListViewCancelMode); } }
    public int ItemIndex { get { return default(int); } }
  }
  public enum ListViewCancelMode {
    CancelingEdit = 0,
    CancelingInsert = 1,
  }
  public partial class ListViewCommandEventArgs : System.Web.UI.WebControls.CommandEventArgs {
    public ListViewCommandEventArgs(System.Web.UI.WebControls.ListViewItem item, object commandSource, System.Web.UI.WebControls.CommandEventArgs originalArgs) : base (default(System.Web.UI.WebControls.CommandEventArgs)) { }
    public object CommandSource { get { return default(object); } }
    public bool Handled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(bool); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.UI.WebControls.ListViewItem Item { get { return default(System.Web.UI.WebControls.ListViewItem); } }
  }
  public partial class ListViewDataItem : System.Web.UI.WebControls.ListViewItem {
    public ListViewDataItem(int dataItemIndex, int displayIndex) : base (default(System.Web.UI.WebControls.ListViewItemType)) { }
    public override object DataItem { get { return default(object); } set { } }
    public override int DataItemIndex { get { return default(int); } }
    public override int DisplayIndex { get { return default(int); } }
    protected override bool OnBubbleEvent(object source, System.EventArgs e) { return default(bool); }
  }
  public partial class ListViewDeletedEventArgs : System.EventArgs {
    public ListViewDeletedEventArgs(int affectedRows, System.Exception exception) { }
    public int AffectedRows { get { return default(int); } }
    public System.Exception Exception { get { return default(System.Exception); } }
    public bool ExceptionHandled { get { return default(bool); } set { } }
    public System.Collections.Specialized.IOrderedDictionary Keys { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
    public System.Collections.Specialized.IOrderedDictionary Values { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
  }
  public partial class ListViewDeleteEventArgs : System.ComponentModel.CancelEventArgs {
    public ListViewDeleteEventArgs(int itemIndex) { }
    public int ItemIndex { get { return default(int); } }
    public System.Collections.Specialized.IOrderedDictionary Keys { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
    public System.Collections.Specialized.IOrderedDictionary Values { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
  }
  public partial class ListViewEditEventArgs : System.ComponentModel.CancelEventArgs {
    public ListViewEditEventArgs(int newEditIndex) { }
    public int NewEditIndex { get { return default(int); } }
  }
  public partial class ListViewInsertedEventArgs : System.EventArgs {
    public ListViewInsertedEventArgs(int affectedRows, System.Exception exception) { }
    public int AffectedRows { get { return default(int); } }
    public System.Exception Exception { get { return default(System.Exception); } }
    public bool ExceptionHandled { get { return default(bool); } set { } }
    public bool KeepInInsertMode { get { return default(bool); } set { } }
    public System.Collections.Specialized.IOrderedDictionary Values { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
  }
  public partial class ListViewInsertEventArgs : System.ComponentModel.CancelEventArgs {
    public ListViewInsertEventArgs(System.Web.UI.WebControls.ListViewItem item) { }
    public System.Web.UI.WebControls.ListViewItem Item { get { return default(System.Web.UI.WebControls.ListViewItem); } }
    public System.Collections.Specialized.IOrderedDictionary Values { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
  }
  [System.ComponentModel.ToolboxItemAttribute(false)]
  public partial class ListViewItem : System.Web.UI.Control, System.Web.UI.IDataItemContainer, System.Web.UI.INamingContainer {
    public ListViewItem(System.Web.UI.WebControls.ListViewItemType itemType) { }
    public virtual object DataItem { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(object); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public virtual int DataItemIndex { get { return default(int); } }
    public virtual int DisplayIndex { get { return default(int); } }
    public System.Web.UI.WebControls.ListViewItemType ItemType { get { return default(System.Web.UI.WebControls.ListViewItemType); } }
    protected override bool OnBubbleEvent(object source, System.EventArgs e) { return default(bool); }
  }
  public partial class ListViewItemEventArgs : System.EventArgs {
    public ListViewItemEventArgs(System.Web.UI.WebControls.ListViewItem item) { }
    public System.Web.UI.WebControls.ListViewItem Item { get { return default(System.Web.UI.WebControls.ListViewItem); } }
  }
  public enum ListViewItemType {
    DataItem = 0,
    EmptyItem = 2,
    InsertItem = 1,
  }
  public partial class ListViewPagedDataSource : System.Collections.ICollection, System.Collections.IEnumerable, System.ComponentModel.ITypedList {
    public ListViewPagedDataSource() { }
    public bool AllowServerPaging { get { return default(bool); } set { } }
    public int Count { get { return default(int); } }
    public System.Collections.IEnumerable DataSource { get { return default(System.Collections.IEnumerable); } set { } }
    public int DataSourceCount { get { return default(int); } }
    public bool IsReadOnly { get { return default(bool); } }
    public bool IsServerPagingEnabled { get { return default(bool); } }
    public bool IsSynchronized { get { return default(bool); } }
    public int MaximumRows { get { return default(int); } set { } }
    public int StartRowIndex { get { return default(int); } set { } }
    public object SyncRoot { get { return default(object); } }
    public int TotalRowCount { get { return default(int); } set { } }
    public void CopyTo(System.Array array, int index) { }
    public System.Collections.IEnumerator GetEnumerator() { return default(System.Collections.IEnumerator); }
    public System.ComponentModel.PropertyDescriptorCollection GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) { return default(System.ComponentModel.PropertyDescriptorCollection); }
    public string GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) { return default(string); }
  }
  public partial class ListViewSelectEventArgs : System.ComponentModel.CancelEventArgs {
    public ListViewSelectEventArgs(int newSelectedIndex) { }
    public int NewSelectedIndex { get { return default(int); } set { } }
  }
  public partial class ListViewSortEventArgs : System.ComponentModel.CancelEventArgs {
    public ListViewSortEventArgs(string sortExpression, System.Web.UI.WebControls.SortDirection sortDirection) { }
    public System.Web.UI.WebControls.SortDirection SortDirection { get { return default(System.Web.UI.WebControls.SortDirection); } set { } }
    public string SortExpression { get { return default(string); } set { } }
  }
  public partial class ListViewUpdatedEventArgs : System.EventArgs {
    public ListViewUpdatedEventArgs(int affectedRows, System.Exception exception) { }
    public int AffectedRows { get { return default(int); } }
    public System.Exception Exception { get { return default(System.Exception); } }
    public bool ExceptionHandled { get { return default(bool); } set { } }
    public bool KeepInEditMode { get { return default(bool); } set { } }
    public System.Collections.Specialized.IOrderedDictionary NewValues { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
    public System.Collections.Specialized.IOrderedDictionary OldValues { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
  }
  public partial class ListViewUpdateEventArgs : System.ComponentModel.CancelEventArgs {
    public ListViewUpdateEventArgs(int itemIndex) { }
    public int ItemIndex { get { return default(int); } }
    public System.Collections.Specialized.IOrderedDictionary Keys { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
    public System.Collections.Specialized.IOrderedDictionary NewValues { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
    public System.Collections.Specialized.IOrderedDictionary OldValues { get { return default(System.Collections.Specialized.IOrderedDictionary); } }
  }
  public partial class NextPreviousPagerField : System.Web.UI.WebControls.DataPagerField {
    public NextPreviousPagerField() { }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.CssClassPropertyAttribute]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_ButtonCssClass")]
    public string ButtonCssClass { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.ButtonType)(2))]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_ButtonType")]
    public System.Web.UI.WebControls.ButtonType ButtonType { get { return default(System.Web.UI.WebControls.ButtonType); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.ImageUrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_FirstPageImageUrl")]
    [System.Web.UI.UrlPropertyAttribute]
    public string FirstPageImageUrl { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.Web.UI.ResourceDefaultValueAttribute("NextPrevPagerField_DefaultFirstPageText")]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_FirstPageText")]
    public string FirstPageText { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.ImageUrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_LastPageImageUrl")]
    [System.Web.UI.UrlPropertyAttribute]
    public string LastPageImageUrl { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.Web.UI.ResourceDefaultValueAttribute("NextPrevPagerField_DefaultLastPageText")]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_LastPageText")]
    public string LastPageText { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute("System.Web.UI.Design.ImageUrlEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_NextPageImageUrl")]
    [System.Web.UI.UrlPropertyAttribute]
    public string NextPageImageUrl { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.Web.UI.ResourceDefaultValueAttribute("NextPrevPagerField_DefaultNextPageText")]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_NextPageText")]
    public string NextPageText { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.ImageUrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_PreviousPageImageUrl")]
    [System.Web.UI.UrlPropertyAttribute]
    public string PreviousPageImageUrl { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.Web.UI.ResourceDefaultValueAttribute("NextPrevPagerField_DefaultPreviousPageText")]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_PreviousPageText")]
    public string PreviousPageText { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_RenderDisabledButtonsAsLabels")]
    public bool RenderDisabledButtonsAsLabels { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_RenderNonBreakingSpacesBetweenControls")]
    public bool RenderNonBreakingSpacesBetweenControls { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_ShowFirstPageButton")]
    public bool ShowFirstPageButton { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(false)]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_ShowLastPageButton")]
    public bool ShowLastPageButton { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_ShowNextPageButton")]
    public bool ShowNextPageButton { get { return default(bool); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("NextPreviousPagerField_ShowPreviousPageButton")]
    public bool ShowPreviousPageButton { get { return default(bool); } set { } }
    protected override void CopyProperties(System.Web.UI.WebControls.DataPagerField newField) { }
    public override void CreateDataPagers(System.Web.UI.WebControls.DataPagerFieldItem container, int startRowIndex, int maximumRows, int totalRowCount, int fieldIndex) { }
    protected override System.Web.UI.WebControls.DataPagerField CreateField() { return default(System.Web.UI.WebControls.DataPagerField); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override void HandleEvent(System.Web.UI.WebControls.CommandEventArgs e) { }
  }
  public partial class NumericPagerField : System.Web.UI.WebControls.DataPagerField {
    public NumericPagerField() { }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute(5)]
    [System.Web.UI.ResourceDescriptionAttribute("NumericPagerField_ButtonCount")]
    public int ButtonCount { get { return default(int); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute((System.Web.UI.WebControls.ButtonType)(2))]
    [System.Web.UI.ResourceDescriptionAttribute("NumericPagerField_ButtonType")]
    public System.Web.UI.WebControls.ButtonType ButtonType { get { return default(System.Web.UI.WebControls.ButtonType); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.CssClassPropertyAttribute]
    [System.Web.UI.ResourceDescriptionAttribute("NumericPagerField_CurrentPageLabelCssClass")]
    public string CurrentPageLabelCssClass { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.ImageUrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.ResourceDescriptionAttribute("NumericPagerField_NextPageImageUrl")]
    [System.Web.UI.UrlPropertyAttribute]
    public string NextPageImageUrl { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.Web.UI.ResourceDefaultValueAttribute("NumericPagerField_DefaultNextPageText")]
    [System.Web.UI.ResourceDescriptionAttribute("NumericPagerField_NextPageText")]
    public string NextPageText { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.CssClassPropertyAttribute]
    [System.Web.UI.ResourceDescriptionAttribute("NumericPagerField_NextPreviousButtonCssClass")]
    public string NextPreviousButtonCssClass { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.CssClassPropertyAttribute]
    [System.Web.UI.ResourceDescriptionAttribute("NumericPagerField_NumericButtonCssClass")]
    public string NumericButtonCssClass { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.ComponentModel.EditorAttribute(typeof(System.Web.UI.Design.ImageUrlEditor), typeof(System.Drawing.Design.UITypeEditor))]
    [System.Web.UI.ResourceDescriptionAttribute("NumericPagerField_PreviousPageImageUrl")]
    [System.Web.UI.UrlPropertyAttribute]
    public string PreviousPageImageUrl { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Appearance")]
    [System.ComponentModel.LocalizableAttribute(true)]
    [System.Web.UI.ResourceDefaultValueAttribute("NumericPagerField_DefaultPreviousPageText")]
    [System.Web.UI.ResourceDescriptionAttribute("NumericPagerField_PreviousPageText")]
    public string PreviousPageText { get { return default(string); } set { } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute(true)]
    [System.Web.UI.ResourceDescriptionAttribute("NumericPagerField_RenderNonBreakingSpacesBetweenControls")]
    public bool RenderNonBreakingSpacesBetweenControls { get { return default(bool); } set { } }
    protected override void CopyProperties(System.Web.UI.WebControls.DataPagerField newField) { }
    public override void CreateDataPagers(System.Web.UI.WebControls.DataPagerFieldItem container, int startRowIndex, int maximumRows, int totalRowCount, int fieldIndex) { }
    protected override System.Web.UI.WebControls.DataPagerField CreateField() { return default(System.Web.UI.WebControls.DataPagerField); }
    public override bool Equals(object o) { return default(bool); }
    public override int GetHashCode() { return default(int); }
    public override void HandleEvent(System.Web.UI.WebControls.CommandEventArgs e) { }
  }
  public partial class PageEventArgs : System.EventArgs {
    public PageEventArgs(int startRowIndex, int maximumRows, int totalRowCount) { }
    public int MaximumRows { get { return default(int); } }
    public int StartRowIndex { get { return default(int); } }
    public int TotalRowCount { get { return default(int); } }
  }
  public partial class PagePropertiesChangingEventArgs : System.EventArgs {
    public PagePropertiesChangingEventArgs(int startRowIndex, int maximumRows) { }
    public int MaximumRows { get { return default(int); } }
    public int StartRowIndex { get { return default(int); } }
  }
  [System.Web.UI.ParseChildrenAttribute(true)]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public abstract partial class QueryableDataSource : System.Web.UI.DataSourceControl, System.Web.UI.IDataSource, System.Web.UI.WebControls.IQueryableDataSource {
    protected QueryableDataSource() { }
    public event System.EventHandler<System.Web.UI.WebControls.QueryCreatedEventArgs> QueryCreated { add { } remove { } }
    protected abstract System.Web.UI.WebControls.QueryableDataSourceView CreateQueryableView();
    protected override System.Web.UI.DataSourceView GetView(string viewName) { return default(System.Web.UI.DataSourceView); }
    protected override System.Collections.ICollection GetViewNames() { return default(System.Collections.ICollection); }
    protected override void LoadViewState(object savedState) { }
    protected internal override void OnInit(System.EventArgs e) { }
    public void RaiseViewChanged() { }
    protected override object SaveViewState() { return default(object); }
    protected override void TrackViewState() { }
    protected virtual void UpdateParameterVales() { }
  }
  public partial class QueryableDataSourceEditData {
    public QueryableDataSourceEditData() { }
    public object NewDataObject { get { return default(object); } set { } }
    public object OriginalDataObject { get { return default(object); } set { } }
  }
  public abstract partial class QueryableDataSourceView : System.Web.UI.DataSourceView, System.Web.UI.IStateManager {
    protected static readonly object EventSelected;
    protected static readonly object EventSelecting;
    protected QueryableDataSourceView(System.Web.UI.DataSourceControl owner, string viewName, System.Web.HttpContext context) : base (default(System.Web.UI.IDataSource), default(string)) { }
    public bool AutoGenerateOrderByClause { get { return default(bool); } set { } }
    public bool AutoGenerateWhereClause { get { return default(bool); } set { } }
    public virtual bool AutoPage { get { return default(bool); } set { } }
    public virtual bool AutoSort { get { return default(bool); } set { } }
    public override bool CanDelete { get { return default(bool); } }
    public override bool CanInsert { get { return default(bool); } }
    public override bool CanPage { get { return default(bool); } }
    public override bool CanRetrieveTotalRowCount { get { return default(bool); } }
    public override bool CanSort { get { return default(bool); } }
    public override bool CanUpdate { get { return default(bool); } }
    public virtual System.Web.UI.WebControls.ParameterCollection DeleteParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    protected abstract System.Type EntityType { get; }
    public virtual string GroupBy { get { return default(string); } set { } }
    public virtual System.Web.UI.WebControls.ParameterCollection GroupByParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    public virtual System.Web.UI.WebControls.ParameterCollection InsertParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    protected bool IsTrackingViewState { get { return default(bool); } }
    public virtual string OrderBy { get { return default(string); } set { } }
    public virtual System.Web.UI.WebControls.ParameterCollection OrderByParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    public virtual string OrderGroupsBy { get { return default(string); } set { } }
    public virtual System.Web.UI.WebControls.ParameterCollection OrderGroupsByParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    public virtual string SelectNew { get { return default(string); } set { } }
    public virtual System.Web.UI.WebControls.ParameterCollection SelectNewParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    public virtual System.Web.UI.WebControls.ParameterCollection UpdateParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    public virtual string Where { get { return default(string); } set { } }
    public virtual System.Web.UI.WebControls.ParameterCollection WhereParameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    public event System.EventHandler<System.Web.UI.WebControls.QueryCreatedEventArgs> QueryCreated { add { } remove { } }
    protected System.Web.UI.WebControls.QueryableDataSourceEditData BuildDeleteObject(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues, System.Collections.Generic.IDictionary<System.String, System.Exception> validationErrors) { return default(System.Web.UI.WebControls.QueryableDataSourceEditData); }
    protected System.Web.UI.WebControls.QueryableDataSourceEditData BuildInsertObject(System.Collections.IDictionary values, System.Collections.Generic.IDictionary<System.String, System.Exception> validationErrors) { return default(System.Web.UI.WebControls.QueryableDataSourceEditData); }
    protected virtual System.Linq.IQueryable BuildQuery(System.Web.UI.DataSourceSelectArguments arguments) { return default(System.Linq.IQueryable); }
    protected System.Web.UI.WebControls.QueryableDataSourceEditData BuildUpdateObjects(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues, System.Collections.Generic.IDictionary<System.String, System.Exception> validationErrors) { return default(System.Web.UI.WebControls.QueryableDataSourceEditData); }
    protected void ClearOriginalValues() { }
    protected System.Web.UI.WebControls.QueryContext CreateQueryContext(System.Web.UI.DataSourceSelectArguments arguments) { return default(System.Web.UI.WebControls.QueryContext); }
    public int Delete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { return default(int); }
    protected virtual int DeleteObject(object oldEntity) { return default(int); }
    protected override int ExecuteDelete(System.Collections.IDictionary keys, System.Collections.IDictionary oldValues) { return default(int); }
    protected override int ExecuteInsert(System.Collections.IDictionary values) { return default(int); }
    protected System.Linq.IQueryable ExecutePaging(System.Linq.IQueryable source, System.Web.UI.WebControls.QueryContext context) { return default(System.Linq.IQueryable); }
    protected virtual System.Linq.IQueryable ExecuteQuery(System.Linq.IQueryable source, System.Web.UI.WebControls.QueryContext context) { return default(System.Linq.IQueryable); }
    protected System.Linq.IQueryable ExecuteQueryExpressions(System.Linq.IQueryable source, System.Web.UI.WebControls.QueryContext context) { return default(System.Linq.IQueryable); }
    protected internal override System.Collections.IEnumerable ExecuteSelect(System.Web.UI.DataSourceSelectArguments arguments) { return default(System.Collections.IEnumerable); }
    protected System.Linq.IQueryable ExecuteSorting(System.Linq.IQueryable source, System.Web.UI.WebControls.QueryContext context) { return default(System.Linq.IQueryable); }
    protected override int ExecuteUpdate(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { return default(int); }
    protected virtual System.Collections.IDictionary GetOriginalValues(System.Collections.IDictionary keys) { return default(System.Collections.IDictionary); }
    protected abstract object GetSource(System.Web.UI.WebControls.QueryContext context);
    protected abstract void HandleValidationErrors(System.Collections.Generic.IDictionary<System.String, System.Exception> errors, System.Web.UI.DataSourceOperation operation);
    public int Insert(System.Collections.IDictionary values) { return default(int); }
    protected virtual int InsertObject(object newEntity) { return default(int); }
    protected virtual void LoadViewState(object savedState) { }
    protected virtual void OnQueryCreated(System.Web.UI.WebControls.QueryCreatedEventArgs e) { }
    protected void OnQueryParametersChanged(object sender, System.EventArgs e) { }
    public void RaiseViewChanged() { }
    protected virtual object SaveViewState() { return default(object); }
    protected virtual void StoreOriginalValues(System.Collections.IList results) { }
    protected void StoreOriginalValues(System.Collections.IList results, System.Func<System.ComponentModel.PropertyDescriptor, System.Boolean> include) { }
    void System.Web.UI.IStateManager.LoadViewState(object state) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
    protected virtual void TrackViewState() { }
    public int Update(System.Collections.IDictionary keys, System.Collections.IDictionary values, System.Collections.IDictionary oldValues) { return default(int); }
    protected virtual int UpdateObject(object oldEntity, object newEntity) { return default(int); }
  }
  public partial class QueryContext {
    public QueryContext(System.Collections.Generic.IDictionary<System.String, System.Object> whereParameters, System.Collections.Generic.IDictionary<System.String, System.Object> orderGroupsByParameters, System.Collections.Specialized.IOrderedDictionary orderByParameters, System.Collections.Generic.IDictionary<System.String, System.Object> groupByParameters, System.Collections.Generic.IDictionary<System.String, System.Object> selectParameters, System.Web.UI.DataSourceSelectArguments arguments) { }
    public System.Web.UI.DataSourceSelectArguments Arguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.DataSourceSelectArguments); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> GroupByParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public System.Collections.Specialized.IOrderedDictionary OrderByParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Specialized.IOrderedDictionary); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> OrderGroupsByParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> SelectParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> WhereParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
  }
  public partial class QueryCreatedEventArgs : System.EventArgs {
    public QueryCreatedEventArgs(System.Linq.IQueryable query) { }
    public System.Linq.IQueryable Query { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Linq.IQueryable); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
  [System.ComponentModel.DefaultPropertyAttribute("TargetControlID")]
  [System.ComponentModel.DesignerAttribute("System.Web.UI.Design.QueryExtenderDesigner, System.Web.Extensions.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
  [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.UI.WebControls.QueryExtender), "QueryExtender.bmp")]
  [System.Web.UI.NonVisualControlAttribute]
  [System.Web.UI.ParseChildrenAttribute(true, "Expressions")]
  [System.Web.UI.PersistChildrenAttribute(false)]
  [System.Web.UI.TargetControlTypeAttribute(typeof(System.Web.UI.WebControls.IQueryableDataSource))]
  public partial class QueryExtender : System.Web.UI.Control {
    public QueryExtender() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    public virtual System.Web.UI.WebControls.IQueryableDataSource DataSource { get { return default(System.Web.UI.WebControls.IQueryableDataSource); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    [System.Web.UI.ResourceDescriptionAttribute("QueryExtender_Expressions")]
    public System.Web.UI.WebControls.Expressions.DataSourceExpressionCollection Expressions { get { return default(System.Web.UI.WebControls.Expressions.DataSourceExpressionCollection); } }
    [System.ComponentModel.CategoryAttribute("Behavior")]
    [System.ComponentModel.DefaultValueAttribute("")]
    [System.Web.UI.IDReferencePropertyAttribute]
    [System.Web.UI.ResourceDescriptionAttribute("ExtenderControl_TargetControlID")]
    public virtual string TargetControlID { get { return default(string); } set { } }
    protected override void LoadViewState(object savedState) { }
    protected internal override void OnInit(System.EventArgs e) { }
    protected override object SaveViewState() { return default(object); }
    protected override void TrackViewState() { }
  }
  public partial class TemplatePagerField : System.Web.UI.WebControls.DataPagerField {
    public TemplatePagerField() { }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DefaultValueAttribute(null)]
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(1))]
    [System.Web.UI.ResourceDescriptionAttribute("TemplatePagerField_PagerTemplate")]
    [System.Web.UI.TemplateContainerAttribute(typeof(System.Web.UI.WebControls.DataPagerFieldItem), (System.ComponentModel.BindingDirection)(1))]
    public virtual System.Web.UI.ITemplate PagerTemplate { get { return default(System.Web.UI.ITemplate); } set { } }
    [System.ComponentModel.CategoryAttribute("Action")]
    [System.Web.UI.ResourceDescriptionAttribute("TemplatePagerField_OnPagerCommand")]
    public event System.EventHandler<System.Web.UI.WebControls.DataPagerCommandEventArgs> PagerCommand { add { } remove { } }
    protected override void CopyProperties(System.Web.UI.WebControls.DataPagerField newField) { }
    public override void CreateDataPagers(System.Web.UI.WebControls.DataPagerFieldItem container, int startRowIndex, int maximumRows, int totalRowCount, int fieldIndex) { }
    protected override System.Web.UI.WebControls.DataPagerField CreateField() { return default(System.Web.UI.WebControls.DataPagerField); }
    public override void HandleEvent(System.Web.UI.WebControls.CommandEventArgs e) { }
    protected virtual void OnPagerCommand(System.Web.UI.WebControls.DataPagerCommandEventArgs e) { }
  }
}
namespace System.Web.UI.WebControls.Expressions {
  [System.Web.UI.ParseChildrenAttribute(true, "Parameters")]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public partial class CustomExpression : System.Web.UI.WebControls.Expressions.ParameterDataSourceExpression {
    public CustomExpression() { }
    public event System.EventHandler<System.Web.UI.WebControls.Expressions.CustomExpressionEventArgs> Querying { add { } remove { } }
    public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
  }
  public partial class CustomExpressionEventArgs : System.EventArgs {
    public CustomExpressionEventArgs(System.Linq.IQueryable source, System.Collections.Generic.IDictionary<System.String, System.Object> values) { }
    public System.Linq.IQueryable Query { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Linq.IQueryable); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Collections.Generic.IDictionary<System.String, System.Object> Values { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Collections.Generic.IDictionary<System.String, System.Object>); } }
  }
  public abstract partial class DataSourceExpression : System.Web.UI.IStateManager {
    protected DataSourceExpression() { }
    protected System.Web.HttpContext Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.HttpContext); } }
    public System.Web.UI.WebControls.IQueryableDataSource DataSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.WebControls.IQueryableDataSource); } }
    protected bool IsTrackingViewState { get { return default(bool); } }
    protected System.Web.UI.Control Owner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.Control); } }
    bool System.Web.UI.IStateManager.IsTrackingViewState { get { return default(bool); } }
    [System.ComponentModel.BrowsableAttribute(false)]
    [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
    protected System.Web.UI.StateBag ViewState { get { return default(System.Web.UI.StateBag); } }
    public abstract System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source);
    protected virtual void LoadViewState(object savedState) { }
    protected virtual object SaveViewState() { return default(object); }
    public virtual void SetContext(System.Web.UI.Control owner, System.Web.HttpContext context, System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
    public void SetDirty() { }
    void System.Web.UI.IStateManager.LoadViewState(object state) { }
    object System.Web.UI.IStateManager.SaveViewState() { return default(object); }
    void System.Web.UI.IStateManager.TrackViewState() { }
    protected virtual void TrackViewState() { }
  }
  public partial class DataSourceExpressionCollection : System.Web.UI.StateManagedCollection {
    public DataSourceExpressionCollection() { }
    public System.Web.HttpContext Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.HttpContext); } }
    public System.Web.UI.WebControls.Expressions.DataSourceExpression this[int index] { get { return default(System.Web.UI.WebControls.Expressions.DataSourceExpression); } set { } }
    public System.Web.UI.Control Owner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.Control); } }
    public void Add(System.Web.UI.WebControls.Expressions.DataSourceExpression expression) { }
    public void Contains(System.Web.UI.WebControls.Expressions.DataSourceExpression expression) { }
    public void CopyTo(System.Web.UI.WebControls.Expressions.DataSourceExpression[] expressionArray, int index) { }
    protected override object CreateKnownType(int index) { return default(object); }
    protected override System.Type[] GetKnownTypes() { return default(System.Type[]); }
    public int IndexOf(System.Web.UI.WebControls.Expressions.DataSourceExpression expression) { return default(int); }
    public void Insert(int index, System.Web.UI.WebControls.Expressions.DataSourceExpression expression) { }
    public void Remove(System.Web.UI.WebControls.Expressions.DataSourceExpression expression) { }
    public void RemoveAt(int index) { }
    protected override void SetDirtyObject(object o) { }
  }
  public partial class MethodExpression : System.Web.UI.WebControls.Expressions.ParameterDataSourceExpression {
    public MethodExpression() { }
    public bool IgnoreIfNotFound { get { return default(bool); } set { } }
    public string MethodName { get { return default(string); } set { } }
    public string TypeName { get { return default(string); } set { } }
    public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
  }
  public partial class OfTypeExpression : System.Web.UI.WebControls.Expressions.DataSourceExpression {
    public OfTypeExpression() { }
    public OfTypeExpression(System.Type type) { }
    [System.ComponentModel.DefaultValueAttribute("")]
    public string TypeName { get { return default(string); } set { } }
    public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable query) { return default(System.Linq.IQueryable); }
  }
  [System.Web.UI.ParseChildrenAttribute(true, "ThenByExpressions")]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public partial class OrderByExpression : System.Web.UI.WebControls.Expressions.DataSourceExpression {
    public OrderByExpression() { }
    public string DataField { get { return default(string); } set { } }
    public System.Web.UI.WebControls.SortDirection Direction { get { return default(System.Web.UI.WebControls.SortDirection); } set { } }
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    public System.Collections.ObjectModel.Collection<System.Web.UI.WebControls.Expressions.ThenBy> ThenByExpressions { get { return default(System.Collections.ObjectModel.Collection<System.Web.UI.WebControls.Expressions.ThenBy>); } }
    public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
  }
  [System.Web.UI.ParseChildrenAttribute(true, "Parameters")]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public abstract partial class ParameterDataSourceExpression : System.Web.UI.WebControls.Expressions.DataSourceExpression {
    protected ParameterDataSourceExpression() { }
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    public System.Web.UI.WebControls.ParameterCollection Parameters { get { return default(System.Web.UI.WebControls.ParameterCollection); } }
    protected override void LoadViewState(object savedState) { }
    protected override object SaveViewState() { return default(object); }
    public override void SetContext(System.Web.UI.Control owner, System.Web.HttpContext context, System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
    protected override void TrackViewState() { }
  }
  public partial class PropertyExpression : System.Web.UI.WebControls.Expressions.ParameterDataSourceExpression {
    public PropertyExpression() { }
    public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
  }
  [System.Web.UI.ParseChildrenAttribute(true, "Expressions")]
  [System.Web.UI.PersistChildrenAttribute(false)]
  public partial class QueryExpression {
    public QueryExpression() { }
    [System.Web.UI.PersistenceModeAttribute((System.Web.UI.PersistenceMode)(2))]
    public System.Web.UI.WebControls.Expressions.DataSourceExpressionCollection Expressions { get { return default(System.Web.UI.WebControls.Expressions.DataSourceExpressionCollection); } }
    public virtual System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
    public void Initialize(System.Web.UI.Control owner, System.Web.HttpContext context, System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
  }
  public partial class RangeExpression : System.Web.UI.WebControls.Expressions.ParameterDataSourceExpression {
    public RangeExpression() { }
    public string DataField { get { return default(string); } set { } }
    public System.Web.UI.WebControls.Expressions.RangeType MaxType { get { return default(System.Web.UI.WebControls.Expressions.RangeType); } set { } }
    public System.Web.UI.WebControls.Expressions.RangeType MinType { get { return default(System.Web.UI.WebControls.Expressions.RangeType); } set { } }
    public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
  }
  public enum RangeType {
    Exclusive = 1,
    Inclusive = 2,
    None = 0,
  }
  public partial class SearchExpression : System.Web.UI.WebControls.Expressions.ParameterDataSourceExpression {
    public SearchExpression() { }
    public System.StringComparison ComparisonType { get { return default(System.StringComparison); } set { } }
    public string DataFields { get { return default(string); } set { } }
    public System.Web.UI.WebControls.Expressions.SearchType SearchType { get { return default(System.Web.UI.WebControls.Expressions.SearchType); } set { } }
    public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { return default(System.Linq.IQueryable); }
  }
  public enum SearchType {
    Contains = 0,
    EndsWith = 2,
    StartsWith = 1,
  }
  public partial class ThenBy {
    public ThenBy() { }
    public string DataField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(string); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    public System.Web.UI.WebControls.SortDirection Direction { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { return default(System.Web.UI.WebControls.SortDirection); } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
  }
}
