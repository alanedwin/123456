using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_123456.Startup))]
namespace _123456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
