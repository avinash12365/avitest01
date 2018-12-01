using System;
using System.Collections.Generic;

namespace Webapp.Models
{
    public partial class HdbQueryTemplate
    {
        public string TemplateName { get; set; }
        public string TemplateDefn { get; set; }
        public string Comment { get; set; }
        public bool? IsSystemDefined { get; set; }
    }
}
