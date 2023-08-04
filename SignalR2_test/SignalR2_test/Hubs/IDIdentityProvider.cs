using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace SignalR2_test.Hubs
{
    public class IDIdentityProvider : IUserIdProvider
    {
        public string? GetUserId(HubConnectionContext connection)
        {
            return connection.User.FindFirst(ClaimTypes.Email)?.Value!;
        }
    }
}
