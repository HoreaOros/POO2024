// See https://aka.ms/new-console-template for more information


class World
{
    private string id;
    public World()
    {
        id = "<noname>";
        Console.WriteLine("Created new world");
    }

    public World(string id)
    {
        this.id = id;
        Console.WriteLine("Created new world");
    }

    public void SayHello()
    {
        Console.WriteLine($"Hello from {id}");
    }
}