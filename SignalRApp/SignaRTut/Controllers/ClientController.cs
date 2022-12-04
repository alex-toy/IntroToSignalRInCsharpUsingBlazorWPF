using Microsoft.AspNetCore.Mvc;

namespace SignaRTut.Controllers
{
	public class ClientController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
