using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OATools.Startup))]
namespace OATools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
