using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErstesBeispiel.Startup))]
namespace ErstesBeispiel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
