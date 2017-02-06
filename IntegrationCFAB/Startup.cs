using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IntegrationCFAB.Startup))]
namespace IntegrationCFAB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
