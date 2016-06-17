using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBaseApplication.Startup))]
namespace MVCBaseApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
