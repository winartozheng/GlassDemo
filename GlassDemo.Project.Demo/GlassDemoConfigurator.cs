using GlassDemo.Project.Demo.Controllers;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace GlassDemo.Project.Demo
{
	public class GlassDemoConfigurator : IServicesConfigurator
	{
		public void Configure(IServiceCollection serviceCollection)
		{
			serviceCollection.AddTransient<GlassDemoController>();
		}
	}
}