using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public class ActivityStatusManager
    {
        private static List<ActivityStatus> _statuses;

        public ActivityStatusManager()
        {
            _statuses = new List<ActivityStatus>();
        }

        public List<ActivityStatus> AddItems()
        {
            List<ActivityStatus> newStatuses = new List<ActivityStatus>();

            int number = new Random().Next(1, 4);
            for (int i = 0; i < number; i++)
            {
                newStatuses.Add(new ActivityStatus
                { 
                    Title = Guid.NewGuid().ToString()
                });
            }
            _statuses.AddRange(newStatuses);
            return newStatuses;
        }

        public List<ActivityStatus> GetItems()
        {
            return _statuses.Where(x=>x.State!=State.Closed).ToList();
        }

        public void Archive(Guid id)
        {
            var activity= _statuses.FirstOrDefault(x => x.Id == id);
            if (activity != null)
            {
                activity.State = State.Closed;
            }
        }
        }
}