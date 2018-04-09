using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebQLDATN.Startup))]
namespace WebQLDATN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
