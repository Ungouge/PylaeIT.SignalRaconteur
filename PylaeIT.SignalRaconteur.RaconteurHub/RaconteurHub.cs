using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace PylaeIT.SignalRaconteur.RaconteurHub
{
    public class RaconteurHub : Hub
    {
        public async Task  SendMessage(string mesage) 
        {
            await Clients.All.SendAsync("ReceiveMessage", mesage);
        }
    }
}
