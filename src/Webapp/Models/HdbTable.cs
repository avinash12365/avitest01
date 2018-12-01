using System;
using System.Collections.Generic;

namespace Webapp.Models
{
    public partial class HdbTable
    {
        public HdbTable()
        {
            HdbPermission = new HashSet<HdbPermission>();
            HdbRelationship = new HashSet<HdbRelationship>();
        }

        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public bool? IsSystemDefined { get; set; }

        public ICollection<HdbPermission> HdbPermission { get; set; }
        public ICollection<HdbRelationship> HdbRelationship { get; set; }
    }
}
