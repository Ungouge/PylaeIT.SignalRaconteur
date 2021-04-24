using System;
using Microsoft.AspNetCore.SignalR.Client;

namespace PylaeIT.SignalRaconteur.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = new HubConnectionBuilder().WithUrl("https://localhost:5001/raconteur").Build();

            var service = new RaconteurService(connection);

            service.MessageReceived += (string message) => Console.WriteLine(message);

            service.Connect().ContinueWith(task =>
            {
                if (task.Exception != null)
                {
                    Console.WriteLine("Connection Error");
                }
            });

            while (true)
            {
                var text = Console.ReadLine();

                if (text.ToLower() == "exit")
                {
                    break;
                }

                service.SendMessage(text);
            }


            Console.WriteLine("Hello World!");
        }
    }
}
