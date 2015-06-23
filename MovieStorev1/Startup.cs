using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieStorev1.Startup))]
namespace MovieStorev1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
