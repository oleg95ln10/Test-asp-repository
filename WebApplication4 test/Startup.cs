using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication4_test.Startup))]
namespace WebApplication4_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
