
using System;

namespace Common
{
    public class ActivityStatus
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public State State { get; set; }

        public ActivityStatus()
        {
            Id = Guid.NewGuid();
        }
    }

    public enum State
    {
        New,
        InProgress,
        Done,
        Closed
    }
}