using System;
using System.Collections.Generic;

namespace Webapp.Models
{
    public partial class HdbRelationship
    {
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string RelName { get; set; }
        public string RelType { get; set; }
        public string RelDef { get; set; }
        public string Comment { get; set; }
        public bool? IsSystemDefined { get; set; }

        public HdbTable Table { get; set; }
    }
}
