using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SqlDependency.Spike.Startup))]
namespace SqlDependency.Spike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
            app.MapSignalR(); 
        }
    }
}
