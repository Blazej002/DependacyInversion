
using DependacyInversion.Server;

namespace Chat.Client
{
    public class ChatClient : IChatClient
    {
        private readonly string _name;
        private readonly ChatServer _server;

        public ChatClient(string name, ChatServer server)
        {
            _name = name;
            _server = server;
            _server.Register(this);
        }

        public void Say(string message)
        {
            _server.Broadcast(this, $"{_name} =>  {message}");
        }

        public void Receive(string message)
        {
            Console.WriteLine($"!{_name}!  {message}");
        }
    }
}
