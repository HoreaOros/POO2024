internal class Rectangle
{
    // properties
    public Point Point { get; init; }
    public int Width{ get; init; }
    public int Height { get; init; }


    // methods
    public override string ToString()
    {
        return $"[Origin: {Point}, Width = {Width}, Height = {Height}]";
    }

}