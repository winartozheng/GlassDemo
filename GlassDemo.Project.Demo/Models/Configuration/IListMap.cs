using Glass.Mapper.Sc.Maps;

namespace GlassDemo.Project.Demo.Models.Configuration
{
	public class IListMap : SitecoreGlassMap<IList>
	{
		public override void Configure()
		{
			Map(config =>
			{
				config.AutoMap();
				config.Id(f => f.Id);
				config.Field(f => f.Title).FieldName("Title");
				config.Field(f => f.Body).FieldName("Body");
			});
		}
	}
}