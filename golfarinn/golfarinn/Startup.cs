using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(golfarinn.Startup))]
namespace golfarinn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
