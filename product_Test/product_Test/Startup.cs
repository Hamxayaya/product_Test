using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(product_Test.Startup))]
namespace product_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
