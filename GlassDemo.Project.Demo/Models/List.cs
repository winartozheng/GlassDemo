using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlassDemo.Project.Demo.Models
{
	//[SitecoreType(TemplateId = Templates.List.Id)]
	public class List
	{
		public virtual string Title { get; set; }
		public virtual Link Url { get; set; }
		public virtual bool InList { get; set; }

	}

	public class ListItems
	{
		[SitecoreChildren]
		public virtual IEnumerable<List> Children { get; set; }
	}
}