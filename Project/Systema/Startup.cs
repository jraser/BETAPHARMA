using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Systema.Startup))]
namespace Systema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
