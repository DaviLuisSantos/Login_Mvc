using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_login.Startup))]
namespace Mvc_login
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
