using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScoreApp.Startup))]
namespace ScoreApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
