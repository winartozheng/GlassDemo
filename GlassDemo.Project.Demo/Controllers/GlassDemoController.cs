using System.Web.Mvc;
using Glass.Mapper.Sc.Web.Mvc;
using GlassDemo.Project.Demo.Models;

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

		public ActionResult DemoList()
		{
			var dataSource = _mvcContext.GetDataSourceItem<IList>();
			return View(dataSource);
		}
	}
}