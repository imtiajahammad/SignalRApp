using System;
using Microsoft.AspNetCore.SignalR;
namespace BlazorServer.Hubs
{
	public class ChatHub : Hub
	{
		/// <summary>
		/// to send message to every clients
		/// </summary>
		/// <param name="user">the user to send</param>
		/// <param name="message">the message to send</param>
		/// <returns></returns>
		public Task SendMessage(string user, string message)
		{
			return Clients.All.SendAsync("ReceiveMessage",user, message);
		}
	}
}

