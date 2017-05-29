using Microsoft.AspNet.SignalR;
using System.Web.Http;
using Common;

namespace SignalRApi.Controllers
{
    public class ActivityStatusController : ApiController
    {
        public IHttpActionResult Post()
        {
            ActivityStatusManager manager = new ActivityStatusManager();
            var newItems = manager.AddItems();

            var hub = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
            hub.Clients.All.statusUpdate(newItems);

            return Ok();
        }
    }
}