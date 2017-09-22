using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stpProject.Startup))]
namespace stpProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
