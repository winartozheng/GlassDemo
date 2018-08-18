using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlassDemo.Project.Demo.Models
{
    [SitecoreType(TemplateId = Templates.DemoCarousel.Id, AutoMap = true)]
    public class Carousel
    {
        public virtual string Title { get; set; }

        [SitecoreChildren]
        public virtual IEnumerable<CarouselItem> Items { get; set; }
    }
}