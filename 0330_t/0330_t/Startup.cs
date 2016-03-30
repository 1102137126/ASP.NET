using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_0330_t.Startup))]
namespace _0330_t
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
