using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Website_01.Startup))]
namespace Website_01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
