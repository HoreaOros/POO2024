// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



internal class World2
{
    private Guid _id;
    private List<string> receivedMessages = new List<string>();

    public World2()
    {
        _id = Guid.NewGuid();
    }
    public void SayHello()
    {
        Console.WriteLine($"Hello from {_id}");
    }

    public void SendMessage(World2 pw2, string message)
    {
        pw2.receivedMessages.Add(message);
    }

    public void DisplayAllMessages()
    {
        Console.WriteLine($"Messages received by: {_id}");
        foreach(var message in receivedMessages) 
        {
            Console.WriteLine(message);
        }
    }
}