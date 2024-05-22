using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_Application3.Startup))]
namespace Web_Application3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
