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
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;

namespace GlassDemo.Project.Demo.Controllers
{
	public class TestController : SitecoreController
	{
		private readonly IMvcContext _mvcContext;

		public TestController(IMvcContext mvcContext)
		{
			_mvcContext = mvcContext;
		}
		public ActionResult HalamanSatu()
		{
			var dataSource = _mvcContext.GetDataSourceItem<PageModel>();
			return View("~/Views/GlassDemo/HalamanSatu.cshtml", dataSource);
		}

	
	}
}