using Microsoft.AspNetCore.Mvc;

namespace SignaRTut.Controllers
{
	public class ServerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
