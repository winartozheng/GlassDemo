using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data.Items;

namespace GlassDemo.Project.Demo.Models
{
    public class MyDemoArticle : ItemBase
    {
      
        public virtual string Header { get; set; }

        [SitecoreField(FieldName ="Header")]
        public virtual string Body { get; set; }
      
        public virtual Image Image { get; set; }
      
        public virtual DateTime Date { get; set; }

        [SitecoreItem]
        public virtual Item Item { get; set; }
    }
}