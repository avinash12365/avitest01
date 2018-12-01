using System;
using System.Collections.Generic;

namespace Webapp.Models
{
    public partial class HdbPermission
    {
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string RoleName { get; set; }
        public string PermType { get; set; }
        public string PermDef { get; set; }
        public string Comment { get; set; }
        public bool? IsSystemDefined { get; set; }

        public HdbTable Table { get; set; }
    }
}
