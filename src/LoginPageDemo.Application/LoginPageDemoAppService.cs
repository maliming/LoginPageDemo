using System;
using System.Collections.Generic;
using System.Text;
using LoginPageDemo.Localization;
using Volo.Abp.Application.Services;

namespace LoginPageDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class LoginPageDemoAppService : ApplicationService
    {
        protected LoginPageDemoAppService()
        {
            LocalizationResource = typeof(LoginPageDemoResource);
        }
    }
}
