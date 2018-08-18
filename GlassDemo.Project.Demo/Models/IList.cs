using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlassDemo.Project.Demo.Models
{
	public interface IList
	{
		Guid Id { get; }
		string Title { get; }
		string Body { get; }
	}
}