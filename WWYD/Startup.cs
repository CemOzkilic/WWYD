using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WWYD.Startup))]
namespace WWYD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
