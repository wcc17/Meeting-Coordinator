using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MeetingCoordinator.Startup))]
namespace MeetingCoordinator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
