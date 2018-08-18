using Glass.Mapper.Sc.Configuration.Attributes;
using System;

namespace GlassDemo.Project.Demo.Models
{
	[SitecoreType(AutoMap=true)]
	public class ItemBase
	{
		[SitecoreId]
		public virtual Guid Id { get; set; }
	}
}