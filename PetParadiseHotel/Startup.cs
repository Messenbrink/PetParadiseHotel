using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetParadiseHotel.Startup))]
namespace PetParadiseHotel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
