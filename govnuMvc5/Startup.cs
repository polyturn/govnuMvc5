using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(govnuMvc5.Startup))]
namespace govnuMvc5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
