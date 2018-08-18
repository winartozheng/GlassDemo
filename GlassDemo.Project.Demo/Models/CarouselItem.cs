using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlassDemo.Project.Demo.Models
{
    [SitecoreType(TemplateId = Templates.CarouselItem.Id, AutoMap = true)]
    public class CarouselItem
    {
        public virtual Image Image { get; set; }
        public virtual string Caption { get; set; }
    }
}