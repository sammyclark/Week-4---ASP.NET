using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week_4___ASP.NET.Startup))]
namespace Week_4___ASP.NET
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
