using LoginPageDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LoginPageDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class LoginPageDemoPageModel : AbpPageModel
    {
        protected LoginPageDemoPageModel()
        {
            LocalizationResourceType = typeof(LoginPageDemoResource);
        }
    }
}