using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignaRTut.Hubs
{
	public class Notificationhub : Hub
	{
		public async Task SendMessages(string msg)
		{
			await Clients.All.SendAsync("ReceiveMessage", msg);
		}
	}
}
