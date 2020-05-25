using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webschool.Startup))]
namespace webschool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
