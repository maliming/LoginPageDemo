using LoginPageDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace LoginPageDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class LoginPageDemoController : AbpController
    {
        protected LoginPageDemoController()
        {
            LocalizationResource = typeof(LoginPageDemoResource);
        }
    }
}