using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DateNightApp.Startup))]
namespace DateNightApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
