using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(a8.Startup))]
namespace a8
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
