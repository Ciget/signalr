using System;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace Common
{
    public class NotificationHub : Hub
    {
        private ActivityStatusManager _manager;

        public NotificationHub()
        {
            _manager = new ActivityStatusManager();

        }

        public void CloseActivity(Guid id)
        {
            _manager.Archive(id);
        }

        //public void Activity()
        //{

        //}

        #region

        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }

        #endregion
    }
}
