using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Solucion_casa.Startup))]
namespace Solucion_casa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
