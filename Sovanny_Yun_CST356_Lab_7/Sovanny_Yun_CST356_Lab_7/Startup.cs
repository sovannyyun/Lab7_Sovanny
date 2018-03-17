using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sovanny_Yun_CST356_Lab_7.Startup))]
namespace Sovanny_Yun_CST356_Lab_7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
