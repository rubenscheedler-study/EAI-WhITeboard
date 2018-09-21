using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace EAI_Whiteboard.Hubs
{
    public class DrawHub : Hub
    {
        public async Task SendUpdate(string eventName, string currentModel)
        {
            await Clients.All.SendAsync("Update", eventName, currentModel);
        }
    }
}