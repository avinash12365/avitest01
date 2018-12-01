using System;
using System.Collections.Generic;

namespace Webapp.Models
{
    public partial class EventInvocationLogs
    {
        public string Id { get; set; }
        public string EventId { get; set; }
        public int? Status { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public DateTime? CreatedAt { get; set; }

        public EventLog Event { get; set; }
    }
}
