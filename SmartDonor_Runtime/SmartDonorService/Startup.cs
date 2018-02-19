using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SmartDonorService.Startup))]

namespace SmartDonorService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}