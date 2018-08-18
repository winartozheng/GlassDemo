using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlassDemo.Project.Demo.Models
{
    public class CarouselItemViewModel
    {
        public int Index { get; set; }
        public string ImageUrl { get; set; }
        public string ImageAlt { get; set; }
        public bool ShowCaption { get; set; }
        public string Caption { get; set; }
        public string Class { get; set; }
    }
}