using System;
using Microsoft.AspNetCore.SignalR.Client;

namespace PylaeIT.SignalRaconteur.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            HubConnection connection = new HubConnectionBuilder().WithUrl("https://localhost:5001").Build();

            Console.WriteLine("Hello World!");
        }
    }
}
