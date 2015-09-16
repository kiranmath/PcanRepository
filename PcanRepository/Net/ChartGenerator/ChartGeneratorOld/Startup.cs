using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChartGenerator.Startup))]
namespace ChartGenerator
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
