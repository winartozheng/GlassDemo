using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data.Items;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace GlassDemo.Project.Demo.Models
{
    public class PageModel : ItemBase
    {
        public virtual string Header { get; set; }

        public virtual string Body { get; set; }
        public virtual string Title { get; set; }

        public virtual DateTime Date { get; set; }

        // public virtual ImageModel Image { get; set; }

        public virtual Image Image { get; set; }

        [SitecoreItem]
        public virtual Item Item { get; set; }
    }
}