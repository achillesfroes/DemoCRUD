using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoCRUD.Startup))]
namespace DemoCRUD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
