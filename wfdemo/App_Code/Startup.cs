using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(wfdemo.Startup))]
namespace wfdemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
