using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repo04.Startup))]
namespace Repo04
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
