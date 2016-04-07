using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstAndLastName.Startup))]
namespace FirstAndLastName
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
