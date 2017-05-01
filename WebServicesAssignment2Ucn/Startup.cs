using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebServicesAssignment2Ucn.Startup))]
namespace WebServicesAssignment2Ucn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
