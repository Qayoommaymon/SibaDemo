using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppBasicDemo.Startup))]
namespace WebAppBasicDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
