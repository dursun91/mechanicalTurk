using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(amazonMechanicalTurk.Startup))]
namespace amazonMechanicalTurk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
