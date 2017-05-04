using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Diary.CQRS.Startup))]
namespace Diary.CQRS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
