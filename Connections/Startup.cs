using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Connections.Startup))]
namespace Connections
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
