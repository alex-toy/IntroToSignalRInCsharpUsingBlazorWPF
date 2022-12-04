using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace BlazorRealTime.Server.Hubs
{
	public class NotificationHub : Hub
	{
		public override Task OnConnectedAsync()
		{
			Debug.WriteLine(Context.ConnectionId);
			return base.OnConnectedAsync();
		}
	}
}
