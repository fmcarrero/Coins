using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coins.Presentation.Startup))]
namespace Coins.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
