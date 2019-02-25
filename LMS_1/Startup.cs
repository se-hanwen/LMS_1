using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LMS_1.Startup))]
namespace LMS_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
