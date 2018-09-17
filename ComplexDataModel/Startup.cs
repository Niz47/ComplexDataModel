using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ComplexDataModel.Startup))]
namespace ComplexDataModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
