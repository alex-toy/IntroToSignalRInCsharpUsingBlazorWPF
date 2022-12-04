using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignaRTut.Hubs;
using SignaRTut.Models;
using System.Threading.Tasks;

namespace SignaRTut.Controllers
{
	public class ServerController : Controller
	{
		private readonly IHubContext<Notificationhub> _notificationHub;

		public ServerController(IHubContext<Notificationhub> notificationHub)
		{
			_notificationHub = notificationHub;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(Notification model)
		{
			await _notificationHub.Clients.All.SendAsync("ReceiveMessage", model.Message);
			return View();
		}
	}
}
