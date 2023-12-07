using System.Security.Cryptography;
using Chat.Client;
using DependacyInversion.Server;

namespace DependacyInversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var server = new ChatServer();

            var client1 = new ChatClient("Blazej", server);
            var client2 = new ChatClient("Dave", server);
            var client3 = new ChatClient("Kåre", server);

            client1.Say("Hello world!!");
            client2.Say("Hello right back!");
            client3.Say("Im tired...");

        }
    }
}
