using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitSampleApp.Startup))]
namespace GitSampleApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
