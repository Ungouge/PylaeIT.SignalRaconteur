using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace PylaeIT.SignalRaconteur.ConsoleApp
{
    public class RaconteurService
    {
        private readonly HubConnection _connection;

        public event Action<string> MessageReceived; 

        public RaconteurService(HubConnection connection)
        {
            _connection = connection;

            _connection.On<string>("ReceiveMessage", (message) => MessageReceived?.Invoke(message));
        }

        public async Task Connect()
        {
            await _connection.StartAsync();
        }

        public async Task SendMessage(string mesage)
        {
            await _connection.SendAsync("SendMessage", mesage);
        }
    }
}
