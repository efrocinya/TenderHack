using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BalticSeaHack.Startup))]
namespace BalticSeaHack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
