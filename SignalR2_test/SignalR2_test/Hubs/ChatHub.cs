using Microsoft.AspNetCore.SignalR;

namespace SignalR2_test.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            IClientProxy client = Clients.Client(user);
            await client.SendAsync("ReceiveMessage", user, message);
            //await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        //public Task SendPrivateMessage(string user, string message)
        //{
        //    Clients.User().SendAsync("")
        //}

        public Task SendMessageToGroup(string sender, string receiver, string message) { 
            return Clients.Group(receiver).SendAsync("ReceiveMessage",sender, message);
        }
    }
}
