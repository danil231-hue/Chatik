using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Chat
{
    public class ChatHub : Hub
    {
        public async Task Send(string message, string userName)
        {
            await Clients.All.SendAsync("Send", message, userName);
        }
    }
}