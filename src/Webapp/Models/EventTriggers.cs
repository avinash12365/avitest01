using System;
using System.Collections.Generic;

namespace Webapp.Models
{
    public partial class EventTriggers
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string Definition { get; set; }
        public string Query { get; set; }
        public string Webhook { get; set; }
        public int? NumRetries { get; set; }
        public int? RetryInterval { get; set; }
        public string Comment { get; set; }
        public string Headers { get; set; }
    }
}
