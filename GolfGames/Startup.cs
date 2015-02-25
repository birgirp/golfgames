using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GolfGames.Startup))]
namespace GolfGames
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
