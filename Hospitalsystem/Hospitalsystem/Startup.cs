using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hospitalsystem.Startup))]
namespace Hospitalsystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
