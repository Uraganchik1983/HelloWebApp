using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWebApp.Startup))]
namespace HelloWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
