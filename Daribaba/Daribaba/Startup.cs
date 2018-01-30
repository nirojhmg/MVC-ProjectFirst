using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Daribaba.Startup))]
namespace Daribaba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
