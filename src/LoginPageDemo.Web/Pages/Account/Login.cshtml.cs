using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using Volo.Abp.Account.Web;
using Volo.Abp.Account.Web.Pages.Account;

namespace LoginPageDemo.Web.Pages.Account
{
    public class MyLoginModel : LoginModel
    {
        public string Message { get; set; }

        public MyLoginModel(IAuthenticationSchemeProvider schemeProvider, IOptions<AbpAccountOptions> accountOptions) 
            : base(schemeProvider, accountOptions)
        {
            Message = "world";
        }
        
    }
}
