using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstMVCProject.Startup))]
namespace FirstMVCProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
