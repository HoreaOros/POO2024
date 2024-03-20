// See https://aka.ms/new-console-template for more information
internal class World
{
    public static readonly World Instance = new World();
    private World() { }
    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}