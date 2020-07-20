using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FrontChallenge.Startup))]
namespace FrontChallenge
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
