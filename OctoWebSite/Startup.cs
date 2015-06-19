using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OctoWebSite.Startup))]
namespace OctoWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
