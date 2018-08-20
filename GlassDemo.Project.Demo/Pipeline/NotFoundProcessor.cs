using Glass.Mapper.Sc.Web;
using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Pipelines.HttpRequest;

namespace GlassDemo.Project.Demo.Pipeline
{
	public class NotFoundProcessor : HttpRequestProcessor
	{
		private readonly IRequestContext _requestContext;

		public NotFoundProcessor(IRequestContext requestContext)
		{
			_requestContext = requestContext;
		}
		public override void Process(HttpRequestArgs args)
		{
			if (IsValidItem())
			{
				return;
			}
			Context.Item = _requestContext.GetHomeItem<Item>();
			
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