using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(unitedhyd5.Startup))]
namespace unitedhyd5
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
