using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using GlassDemo.Project.Demo.Models;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;

namespace GlassDemo.Project.Demo.Controllers
{
	public class GlassDemoController : Controller
	{
		private readonly IMvcContext _mvcContext;

		public GlassDemoController(IMvcContext mvcContext)
		{
			_mvcContext = mvcContext;
		}
		public ActionResult DemoArticle()
		{
			var dataSource = _mvcContext.GetDataSourceItem<DemoArticle>();
			return View(dataSource);
		}

		public ActionResult DemoFluentArticle()
		{
			var dataSource = _mvcContext.GetDataSourceItem<IFluentArticle>();
			return View(dataSource);
		}

		public ActionResult DemoNoGlassArticle()
		{
			var dataSourceItem = RenderingContext.Current.Rendering.Item;
			var demoArticleNoGlass = new DemoArticleNoGlass()
			{
				Header = new HtmlString(FieldRenderer.Render(dataSourceItem, "Header")),
				Body = new HtmlString(FieldRenderer.Render(dataSourceItem, "Body")),
				Image = new HtmlString(FieldRenderer.Render(dataSourceItem, "Image", "mw=400")),
				Date = new HtmlString(FieldRenderer.Render(dataSourceItem, "Date"))
			};
			return View(demoArticleNoGlass);
		}

		public ActionResult ApiList()
		{
			var currentItem = Sitecore.Context.Item;
			var listItems = new List<ListItem>();

			foreach (Item child in currentItem.Children)
			{
				var display = new CheckboxField(child.Fields["Display in List"]);
				if (display.Checked)
				{
					var listItem = new ListItem();
					listItem.Title = child["Title"];
					listItem.Url = LinkManager.GetItemUrl(child);

					listItems.Add(listItem);
				}
			}

			return View(listItems);
		}

		public ActionResult DemoCarousel()
		{
			// example for lazy loading & SitecoreService:
			Database masterDb = Sitecore.Configuration.Factory.GetDatabase("master");
			ISitecoreService service = new SitecoreService(masterDb);

			Carousel target = service.GetItem<Carousel>("/sitecore/content/Home/New MVC Page/Assets/DemoCarousel", x => x.LazyDisabled());
			var options = new GetItemByIdOptions(System.Guid.NewGuid())
			{
				InferType = true,
				Lazy = Glass.Mapper.LazyLoading.Disabled
			};
			var target2 = service.GetItem<Carousel>(options);
			// example end



			var dataSource = _mvcContext.GetDataSourceItem<Carousel>();

			var viewModel = new CarouselViewModel
			{
				Title = dataSource.Title
			};
			for (var i = 0; i < dataSource.Items.Count(); i++)
			{
				var item = dataSource.Items.ElementAt(i);
				viewModel.Items.Add(new CarouselItemViewModel
				{
					Index = i,
					ImageUrl = item.Image?.Src,
					ImageAlt = item.Image?.Alt,
					ShowCaption = !string.IsNullOrEmpty(item.Caption),
					Caption = item.Caption,
					Class = i == 0 ? "active" : string.Empty
				});
			}

			return View(viewModel);
		}
	}
}