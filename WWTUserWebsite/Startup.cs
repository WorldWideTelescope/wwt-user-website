using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WWTUserWebsite.Startup))]
namespace WWTUserWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
