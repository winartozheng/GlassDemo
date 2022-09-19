#region GlassMapperScCustom generated code
using Glass.Mapper.Configuration;
using Glass.Mapper.Configuration.Attributes;
using Glass.Mapper.IoC;
using Glass.Mapper.Maps;
using Glass.Mapper.Sc.IoC;
using GlassDemo.Project.Demo.Models.Configuration;
using IDependencyResolver = Glass.Mapper.Sc.IoC.IDependencyResolver;

namespace GlassDemo.Project.Demo.App_Start
{
    public static  class GlassMapperScCustom
    {
		public static IDependencyResolver CreateResolver(){
			var config = new Glass.Mapper.Sc.Config();

			var dependencyResolver = new DependencyResolver(config);
			// add any changes to the standard resolver here
			return dependencyResolver;
		}

		public static IConfigurationLoader[] GlassLoaders(){

			/* USE THIS AREA TO ADD FLUENT CONFIGURATION LOADERS
             * 
             * If you are using Attribute Configuration or automapping/on-demand mapping you don't need to do anything!
             * 
             */
			var attributes = new AttributeConfigurationLoader("GlassDemo.Project.Demo");

			return new IConfigurationLoader[] { attributes };
	
		}
		public static void PostLoad(){
			
		}
		public static void AddMaps(IConfigFactory<IGlassMap> mapsConfigFactory)
        {
			// Add maps here
             mapsConfigFactory.Add(() => new IFluentArticleMap());
			 //mapsConfigFactory.Add(() => new PageModelMap());
		}
    }
}
#endregion