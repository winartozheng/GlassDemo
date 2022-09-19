using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Maps;
using GlassDemo.Project.Demo.Models;

namespace GlassDemo.Project.Demo.Models.Configuration
{
    public class PageModelMap : SitecoreGlassMap<PageModel>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.Id(f => f.Id);
                //config.Field(f => f.Header).FieldId("{C4C6F216-5FA2-41E8-BF5D-748EBC7B2A60}");
                config.Field(f => f.Title).FieldName("Header");
                
            });
        }
    }
}