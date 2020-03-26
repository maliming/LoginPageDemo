using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using LoginPageDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LoginPageDemo.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits LoginPageDemo.Web.Pages.LoginPageDemoPage
     */
    public abstract class LoginPageDemoPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<LoginPageDemoResource> L { get; set; }
    }
}
