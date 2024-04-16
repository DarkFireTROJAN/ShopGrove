using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopGrove.Startup))]
namespace ShopGrove
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
