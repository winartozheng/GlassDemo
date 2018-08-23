using System;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data.Items;

namespace GlassDemo.Project.Demo.Models
{
    [SitecoreType(TemplateId = Templates.GlassArticle.Id)]
    public class DemoArticle : ItemBase
    {
        [SitecoreField(FieldId = "{9EE4FF97-AA13-4488-8557-B6A95F02AD81}")]
        public virtual string Header { get; set; }
        [SitecoreField(FieldId = "{B33619D0-5D22-49E9-B72A-D72A89FA7A80}")]
        public virtual string Body { get; set; }
        [SitecoreField(FieldId = "{AAA8E4C8-69BC-4D7B-B017-0284E3088C76}")]
        public virtual Image Image { get; set; }
        [SitecoreField(FieldId = "{26C8ABD8-0D0A-4CD1-9125-8F908ABDAC2A}")]
        public virtual DateTime Date { get; set; }

		[SitecoreItem]
		public virtual Item Item { get; set; }
    }
}