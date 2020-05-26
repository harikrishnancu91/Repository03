using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Repo03.Startup))]
namespace Repo03
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
