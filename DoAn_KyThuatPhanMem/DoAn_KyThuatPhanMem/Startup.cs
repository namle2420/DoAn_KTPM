using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAn_KyThuatPhanMem.Startup))]
namespace DoAn_KyThuatPhanMem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
