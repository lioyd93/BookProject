using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoolBooksProject.Startup))]
namespace CoolBooksProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
