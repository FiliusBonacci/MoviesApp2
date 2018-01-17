using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesApp2.Startup))]
namespace MoviesApp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
