using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Practice_1.Startup))]
namespace Practice_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
