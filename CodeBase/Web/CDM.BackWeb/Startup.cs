using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CDM.BackWeb.Startup))]
namespace CDM.BackWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
