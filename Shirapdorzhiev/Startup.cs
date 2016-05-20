using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Shirapdorzhiev.Startup))]
namespace Shirapdorzhiev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
