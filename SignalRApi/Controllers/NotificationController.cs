using Microsoft.AspNet.SignalR;
using System.Web.Http;
using Common;

namespace SignalRApi.Controllers
{
    public class NotificationController : ApiController
    {
        public IHttpActionResult Post()
        {
            var hub = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            hub.Clients.All.notify();
            return Ok();
        }
    }
}