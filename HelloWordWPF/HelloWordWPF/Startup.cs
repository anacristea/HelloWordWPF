using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWordWPF.Startup))]
namespace HelloWordWPF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
