using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Emir.WebUI.Startup))]
namespace Emir.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
