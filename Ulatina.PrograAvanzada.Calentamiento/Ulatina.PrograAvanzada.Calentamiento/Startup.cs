using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ulatina.PrograAvanzada.Calentamiento.Startup))]
namespace Ulatina.PrograAvanzada.Calentamiento
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
