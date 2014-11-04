using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GeekGuestbook.Startup))]
namespace GeekGuestbook
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
