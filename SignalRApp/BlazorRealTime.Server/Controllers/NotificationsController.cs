using BlazorRealTime.Server.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace BlazorRealTime.Server.Controllers
{
	[Route("/api/[controller]")]
	[ApiController]
	public class NotificationsController : Controller
	{
		private readonly IHubContext<NotificationHub> _hubContext;

		public NotificationsController(IHubContext<NotificationHub> hubContext)
		{
			_hubContext = hubContext;
		}

		[HttpPost("send")]
		public async Task<IActionResult> Post([FromQuery] string title)
		{
			await _hubContext.Clients.All.SendAsync("notification", $"{DateTime.Now} : {title}");
			return Ok("Notification sent with success.");
		}
	}
}
