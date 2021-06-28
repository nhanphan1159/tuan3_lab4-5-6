using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab4_5_6.Startup))]
namespace lab4_5_6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
