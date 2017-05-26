using System.Collections.Generic;

namespace SignalRWeb
{
    public class ActivityStatusManager
    {
        public List<ActivityStatus> GetItems()
        {
            return new List<ActivityStatus>
                {
                 new ActivityStatus
                 {
                     Title = "First title"
                 },
                 new ActivityStatus
                 {
                     Title = "Second message"
                 }
                };
        }
    }
}