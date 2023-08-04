using Microsoft.AspNetCore.SignalR;

namespace SignalR_Test.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message, string otherInput)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, otherInput);
        }
    }
}
