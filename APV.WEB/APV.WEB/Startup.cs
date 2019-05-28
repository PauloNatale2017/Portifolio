using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(APV.WEB.Startup))]
namespace APV.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
