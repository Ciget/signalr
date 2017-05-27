using System.Configuration;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;
using SignalRWeb;

[assembly: OwinStartup(typeof(Startup))]
namespace SignalRWeb
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var connectionStr = ConfigurationManager.ConnectionStrings["signalr"].ConnectionString;
            GlobalHost.DependencyResolver.UseSqlServer(connectionStr);

            app.MapSignalR();
        }
    }
}