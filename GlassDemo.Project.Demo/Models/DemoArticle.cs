using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace GlassDemo.Project.Demo.Models
{
    [SitecoreType(TemplateId = Templates.GlassArticle.Id, AutoMap = true)]
    public class DemoArticle
    {
        public virtual string Header { get; set; }
        public virtual string Body { get; set; }
        public virtual Image Image { get; set; }
        public virtual DateTime Date { get; set; }
    }
}