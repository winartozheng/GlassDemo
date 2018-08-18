using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlassDemo.Project.Demo.Models
{
    public class CarouselViewModel
    {
        public string Title { get; set; }
        public IList<CarouselItemViewModel> Items { get; set; }

        public CarouselViewModel()
        {
            Items = new List<CarouselItemViewModel>();
        }
    }
}