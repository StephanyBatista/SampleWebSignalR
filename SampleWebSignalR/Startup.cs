using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SampleWebSignalR.Startup))]
namespace SampleWebSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}