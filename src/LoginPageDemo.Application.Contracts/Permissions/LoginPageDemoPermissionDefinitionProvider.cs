using LoginPageDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LoginPageDemo.Permissions
{
    public class LoginPageDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(LoginPageDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(LoginPageDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<LoginPageDemoResource>(name);
        }
    }
}
