using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nextcars.Startup))]
namespace nextcars
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
