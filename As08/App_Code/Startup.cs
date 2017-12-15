using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(As08.Startup))]
namespace As08
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
