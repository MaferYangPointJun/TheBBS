using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BBSProject20150301.Startup))]
namespace BBSProject20150301
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
