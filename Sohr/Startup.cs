using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sohr.Startup))]
namespace Sohr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
