using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace LoginPageDemo.Pages
{
    public class Index_Tests : LoginPageDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
