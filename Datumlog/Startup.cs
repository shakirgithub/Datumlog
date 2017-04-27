using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Datumlog.Startup))]
namespace Datumlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
