using System;
using System.Collections.Generic;

namespace Webapp.Models
{
    public partial class EventLog
    {
        public EventLog()
        {
            EventInvocationLogs = new HashSet<EventInvocationLogs>();
        }

        public string Id { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string TriggerId { get; set; }
        public string TriggerName { get; set; }
        public string Payload { get; set; }
        public bool Delivered { get; set; }
        public bool Error { get; set; }
        public int Tries { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool Locked { get; set; }
        public DateTime? NextRetryAt { get; set; }

        public ICollection<EventInvocationLogs> EventInvocationLogs { get; set; }
    }
}
