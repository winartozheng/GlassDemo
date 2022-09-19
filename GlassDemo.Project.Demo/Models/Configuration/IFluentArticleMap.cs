using Glass.Mapper.Sc.Maps;

namespace GlassDemo.Project.Demo.Models.Configuration
{
	public class IFluentArticleMap : SitecoreGlassMap<IFluentArticle>
	{
		public override void Configure()
		{
			Map(config =>
			{
				config.AutoMap();
				config.Id(f => f.Id);
				config.Field(f => f.Title).FieldName("Header");
				config.Field(f => f.Body).FieldName("Body");
			});
		}
	}
}