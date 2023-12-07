namespace DependacyInversion.Server;

public class ChatServer
{
    readonly List<IChatClient> _clients;

    public ChatServer()
    {
        _clients = new List<IChatClient>();
    }

    public void Broadcast(IChatClient client, string message)
    {
        foreach (var chatClient in _clients)
        {
            if (chatClient != client)
            {
                chatClient.Receive(message);
                Console.WriteLine();
            }
        }
    }

    public void Register(IChatClient NewClient)
    {
        _clients.Add(NewClient);
    }
}