internal class Circle
{
    // properties
    public Point? Point { get; init; }
    public int Radius { get; init; }


    // c-tors
    public Circle(Point p, int radius)
    {
        this.Point = p;
        this.Radius = radius;
    }
    public Circle()
    { 
    }

    // methods
    public override string ToString()
    {
        return $"[Origin: {Point}, Radius = {Radius}]";
    }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
    public double Perimeter() // lungimea cercului
    {
        return 2 * Math.PI * Radius;
    }
}