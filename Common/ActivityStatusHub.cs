using System;
using System.Collections.Generic;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace Common
{
    [HubName("ActivityStatus")]
    public class ActivityStatusHub : Hub
    {
        private readonly ActivityStatusManager _manager;

        public ActivityStatusHub()
        {
            _manager = new ActivityStatusManager();
        }

        public IList<ActivityStatus> GetStatuses()
        {
            Clients.All.addNewActivity(Guid.NewGuid().ToString());
            return _manager.GetItems();
        }
    }
}