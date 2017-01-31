using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectEuler.Controllers
{
	public class Problem1Controller : Controller
	{
		// GET: Problem1
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Answer()
		{
			var answer = Solvers.Problem1.GetAnswer();
			return View(answer);
		}
	}
}