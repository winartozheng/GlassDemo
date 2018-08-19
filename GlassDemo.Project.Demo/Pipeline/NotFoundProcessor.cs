using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web;
using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Pipelines.HttpRequest;
using System;

namespace GlassDemo.Project.Demo.Pipeline
{
	public class NotFoundProcessor : HttpRequestProcessor
	{

		public override void Process(HttpRequestArgs args)
		{
			var requestContext = new RequestContext(new SitecoreService("master"));
			if (IsValidItem())
			{
				return;
			}
			Context.Item = requestContext.GetHomeItem<Item>();
			
		}

		public bool IsValidItem()
		{
			bool isValid = Context.Site != null
				&& Context.Item != null
				&& Context.Item.Visualization.Layout != null;

			return isValid;
		}
	}
}