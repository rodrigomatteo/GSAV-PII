using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GSAV.Web.Startup))]
namespace GSAV.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
