using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DA.FrontEnd.Startup))]
namespace DA.FrontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
