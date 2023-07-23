using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WorldHorizon.MVC.Models;

namespace WorldHorizon.MVC.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}