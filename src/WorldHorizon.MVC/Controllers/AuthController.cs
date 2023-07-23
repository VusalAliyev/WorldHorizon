using Microsoft.AspNetCore.Mvc;

namespace WorldHorizon.MVC.Controllers
{
	public class AuthController : Controller
	{
		public IActionResult Login()
		{
			return View();
		}
		public IActionResult Register()
		{
			return View();
		}
		public IActionResult ForgotPassword()
		{
			return View();
		}
		public IActionResult VerifyOTP()
		{
			return View();
		}
		public IActionResult ResetPassword()
		{
			return View();
		}
		public IActionResult Yoxlama()
		{
			return View();
		}
	}
}
